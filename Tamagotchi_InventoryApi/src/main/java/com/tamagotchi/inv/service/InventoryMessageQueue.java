package com.tamagotchi.inv.service;

import javax.jms.Queue;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.annotation.JmsListener;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.scheduling.annotation.Async;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.tamagotchi.inv.model.Inventory;
import com.tamagotchi.inv.model.ModelItem;
import com.tamagotchi.inv.model.ModelRequestItems;
import com.tamagotchi.inv.model.ModelRequestItemsResponse;
import com.tamagotchi.inv.repository.InventoryRepository;

@RestController
@RequestMapping("/Message")
public class InventoryMessageQueue {

	@Autowired
	private InventoryRepository repository;

	@Autowired
	private JmsTemplate jmsTemplate;

	@Autowired
	private Queue AddFoodInvResponeQueue;

	@Autowired
	private Queue RequestAllItemQueue;

	@Async
	@GetMapping("/GetAllItems/{userid}")
	private ModelRequestItemsResponse GetALLItems(@PathVariable String userid) throws InterruptedException {
		Inventory inv = repository.findById(userid).orElse(null);

		ModelRequestItems request = new ModelRequestItems();
		request.Items = inv.itemId;
		request.userId = userid;

		jmsTemplate.convertAndSend(RequestAllItemQueue, request);

		boolean reply = false;

		while (!reply) {
			ModelRequestItemsResponse items = (ModelRequestItemsResponse) jmsTemplate
					.receive("requestallitemresponse.queue");

			if (items.UserId == userid) {
				return items;
			}else {
				Thread.sleep(200);
				jmsTemplate.convertAndSend("requestallitemresponse.queue", items);
			}
		}
		return null;
	}

	@JmsListener(destination = "addfoodinv.queue")
	private void AddFoodInv(ModelItem item) {
		Inventory inv = repository.findById(item.userId).orElse(null);
		inv.itemId.add(item.itemId);

		repository.save(inv);

		item.confirmation = true;

		jmsTemplate.convertAndSend(AddFoodInvResponeQueue, item);
	}
}
