package com.tamagotchi.databuilder;

import javax.jms.Queue;

import org.apache.activemq.command.ActiveMQQueue;
import org.springframework.context.annotation.Bean;

public class Queue_Factory {
	
	@Bean 
	public Queue TestingQueue() {
		return new ActiveMQQueue("ShopTestQueue");
	}
}
