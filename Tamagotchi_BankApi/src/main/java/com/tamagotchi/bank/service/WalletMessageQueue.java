package com.tamagotchi.bank.service;

import javax.jms.Queue;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.annotation.JmsListener;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.tamagotchi.bank.model.ModelBankFood;
import com.tamagotchi.bank.model.Wallet;
import com.tamagotchi.bank.repository.WalletRepository;

@RestController
@RequestMapping("/Message")
public class WalletMessageQueue {

	@Autowired
	private WalletRepository repository;
	@Autowired
	private JmsTemplate jmsTemplate;
	@Autowired
	private Queue BuyFoodReceiveQueue;
	
	@JmsListener(destination = "buyfoodsend.queue")
	private void PurchaseListener(ModelBankFood purchase) {
		Wallet wallet = repository.findById(purchase.userId).orElse(null);
		if(wallet.Balance - purchase.price >= 0) {
			wallet.Balance -= purchase.price;
			
			repository.save(wallet);
			
			purchase.affordable = true;
			jmsTemplate.convertAndSend(BuyFoodReceiveQueue, purchase);
		}else {
			purchase.affordable = false;
			jmsTemplate.convertAndSend(BuyFoodReceiveQueue, purchase);
		}
	}
}
