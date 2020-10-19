package com.tamagotchi.message.resource;

import javax.jms.Queue;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/rest/publish")
public class ProducerResource {

	@Autowired
	JmsTemplate jmsTemplate;
	
	@Autowired
	Queue queue;
	
	
	@GetMapping("/{message}")
	public String publish(@PathVariable("message")
	final String message) {
		for(int i = 0; i < 100; i++) {			
			jmsTemplate.convertAndSend(queue, message);
		}
		
		return "Published " + message +  " Succesfully";
	}
}
