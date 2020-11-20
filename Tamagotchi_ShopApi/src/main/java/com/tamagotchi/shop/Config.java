package com.tamagotchi.shop;

import javax.jms.Queue;

import org.apache.activemq.ActiveMQConnectionFactory;
import org.apache.activemq.command.ActiveMQQueue;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.jms.support.converter.MappingJackson2MessageConverter;
import org.springframework.jms.support.converter.MessageConverter;
import org.springframework.jms.support.converter.MessageType;

@Configuration
public class Config {

	@Value("${spring.activemq.broker-url}")
	private String brokerUrl;
	@Value("${spring.activemq.user}")
	private String username;
	@Value("${spring.activemq.password}")
	private String password;
	
	//Food to Bank
	@Bean
	public Queue BuyFoodQueueSend() {
		return new ActiveMQQueue("buyfoodsend.queue");
	}
	@Bean
	public String BuyFoodQueueReceive() {
		return "buyfoodreceive.queue";
	}
	
	//Food to inventory
	@Bean 
	public Queue AddFoodInvQueue() {
		return new ActiveMQQueue("addfoodinv.queue");
	}
	@Bean
	public String AddFoodInvResponse() {
		return "addfoodinvresponse.queue";
	}
	
	//getting all foods
	@Bean 
	public Queue RequestAllItemResponseQueue() {
		return new ActiveMQQueue("requestallitemresponse.queue");
	}
	
	@Bean 
	public ActiveMQConnectionFactory activeMQConnectionFactory() {
		ActiveMQConnectionFactory factory = new ActiveMQConnectionFactory();
		factory.setBrokerURL(brokerUrl);
		factory.setUserName(username);
		factory.setPassword(password);
		return factory;
	}
	
	@Bean
	public MessageConverter jacksonJmsMessageConverter() {
		MappingJackson2MessageConverter converter = new MappingJackson2MessageConverter();
		converter.setTargetType(MessageType.TEXT);
		converter.setTypeIdPropertyName("_type");
		return converter;
	}
	
	@Bean
	public JmsTemplate jmsTemplate() {
		JmsTemplate template = new JmsTemplate();
		template.setConnectionFactory(activeMQConnectionFactory());
		template.setMessageConverter(jacksonJmsMessageConverter());
		return template;
	}
}

