package com.tamagotchi.shop.service;

import javax.jms.Queue;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.jms.annotation.JmsListener;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.transaction.annotation.Transactional;

import com.tamagotchi.shop.template.TestTemplate;

@Transactional
@ComponentScan(basePackages = {"com.tamagotchi.shop.service", "com.tamagotchi.shop.model", "com.tamagotchi.shop.repository"})
public class MessageControllerTest extends TestTemplate{
	
	@Autowired
	private FoodMessageQueueController controller;
	
	@Autowired
	private JmsTemplate jmsTemplate;

	@Autowired
	private Queue TestingQueue;
	
	@Before
	public void setUp() {
		//Setting up tests
	}
	
	@After
	public void tearDown() {
		//cleaning tests after finishes
	}
	
	@Test
	@JmsListener(destination = "ShopTestQueue")
	public void ActiveMqConnectionTest(String message) {
		//Assign
		final String sent = "messageTest";
		
		//Act
		jmsTemplate.convertAndSend(TestingQueue, message);
		
		//Assert
		Assert.assertEquals(sent, message);
	}
}
