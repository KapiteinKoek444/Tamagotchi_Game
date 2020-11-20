package com.tamagotchi.shop.service;

import javax.jms.Queue;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.annotation.JmsListener;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.tamagotchi.shop.model.Food;
import com.tamagotchi.shop.model.ModelBankFood;
import com.tamagotchi.shop.model.ModelItem;
import com.tamagotchi.shop.model.ModelRequestItems;
import com.tamagotchi.shop.model.ModelRequestItemsResponse;
import com.tamagotchi.shop.repository.FoodRepository;

@RestController
@RequestMapping("/Message")
public class FoodMessageQueueController {

	@Autowired
	private FoodRepository repository;
	
	@Autowired
	private JmsTemplate jmsTemplate;

	@Autowired
	private Queue BuyFoodQueueSend;
	
	@Autowired
	private Queue AddFoodInvQueue;
	
	@Autowired
	private Queue RequestAllItemResponseQueue;

	@GetMapping("/BuyFood/{id}/{userid}")
	private void BuyFood(@PathVariable String id,
			@PathVariable String userid) {
		Food food = repository.findById(id).orElse(null);
		
		ModelBankFood request = new ModelBankFood();
		request.price = food.price - food.discount;
		request.userId = userid;
		
		jmsTemplate.convertAndSend(BuyFoodQueueSend, request);
	}
	
	@JmsListener(destination = "buyfoodreceive.queue")
	private String AwaitbankConfirmation(ModelBankFood confirmation) {
		
		if(confirmation.affordable == true) {
			ModelItem item = new ModelItem();
			item.userId = confirmation.userId;
			item.itemId = confirmation.itemId;
			
			jmsTemplate.convertAndSend(AddFoodInvQueue, item);
			
			return "Succesfully bought item!!";
		}else {
			return "Error, not enough funds";
		}
	}
	
	@JmsListener(destination = "addfoodinvresponse.queue")
	private void AwaitInvConfirmation(ModelItem item) {
		if(item.confirmation = true) {
		}else {
		}
	}
	
	@JmsListener(destination = "requestallitemresponse.queue")
	private void RequestAllItems(ModelRequestItems items) {
		ModelRequestItemsResponse response = new ModelRequestItemsResponse();
		response.UserId = items.userId;
		
		for(String id : items.Items){
			Food food = repository.findById(id).orElse(null);
			response.Items.add(food);
		}
		
		jmsTemplate.convertAndSend(RequestAllItemResponseQueue, response);
	}
}
