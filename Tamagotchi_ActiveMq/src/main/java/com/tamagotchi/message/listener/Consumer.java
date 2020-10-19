package com.tamagotchi.message.listener;

import org.springframework.jms.annotation.JmsListener;
import org.springframework.stereotype.Component;

@Component
public class Consumer {

	@JmsListener(destination = "MickeyTest")
	public void consume(String message) {
		
		System.out.println("Recieved message" + message);
	}
}
