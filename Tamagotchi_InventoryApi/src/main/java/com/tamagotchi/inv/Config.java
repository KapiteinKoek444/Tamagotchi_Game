package com.tamagotchi.inv;

import javax.jms.Queue;

import org.apache.activemq.ActiveMQConnectionFactory;
import org.apache.activemq.command.ActiveMQQueue;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.jms.core.JmsTemplate;

@Configuration
public class Config {

	@Value("${spring.activemq.broker-url}")
	private String brokerUrl;
	@Value("${spring.activemq.user}")
	private String username;
	@Value("${spring.activemq.password}")
	private String password;
	
	@Bean
	public Queue AddFoodInvResponeQueue() {
		return new ActiveMQQueue("addfoodinvresponse.queue");
	}
	
	@Bean 
	public Queue RequestAllItemQueue() {
		return new ActiveMQQueue("requestallitem.queue");
	}
	
	@Bean
	public String RequestAllItemResponseQueue() {
		return "requestallitemresponse.queue";
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
	public JmsTemplate jmsTemplate() {
		return new JmsTemplate(activeMQConnectionFactory());
	}
}
