package com.tamagotchi.shop.service;

import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.TextMessage;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.annotation.JmsListener;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.tamagotchi.shop.model.ModelUser;

@RestController
@RequestMapping("/Test")
public class TestController {
	
	@Autowired
	private JmsTemplate jmsTemplate;
	
	@GetMapping("/test")
	public String Test() {
		ModelUser user = new ModelUser();
		user.Email = "kaas@kaas.kaas";
		user.Id = "bb009077-fc20-4880-ac9f-d42560d97b5b";
		user.Password = "DitisGeheim123";

		jmsTemplate.convertAndSend("testing.queue", user);
		return "published Succesfully";
	}

	@JmsListener(destination = "")
	public void BuyFoodListener(Message message) throws JMSException, JsonMappingException, JsonProcessingException {
		String m = ((TextMessage) message).getText().toString();
		ModelUser[] u = new ObjectMapper().readValue(m, ModelUser[].class);
		System.out.println(u[0].Id);
	}
}
