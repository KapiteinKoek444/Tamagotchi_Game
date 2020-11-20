package service;

import java.util.List;

import javax.jms.Connection;
import javax.jms.Destination;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageConsumer;
import javax.jms.MessageProducer;
import javax.jms.Session;
import javax.jms.TextMessage;

import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.BeforeClass;
import org.junit.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.transaction.annotation.Transactional;

import com.tamagotchi.shop.service.FoodMessageQueueController;

import shop.TestTemplate;

@Transactional
public class MessageControllerTest extends TestTemplate{
	
	@Autowired
	private FoodMessageQueueController controller;
	
	@Autowired
	private JmsTemplate jmstemplate;
	
	private Connection connection;
	
	@BeforeClass
	public void setUp() throws JMSException {
		connection = jmstemplate.getConnectionFactory().createConnection();
		connection.start();
	}
	
	@AfterClass
	public void tearDown() throws JMSException {
		connection.close();
	}
	
	@Test
	public void MessageConnectionTest() throws Exception{
		String ExpectedText = "Hello world test!!";
		
		//Creating session
		Session session = connection.createSession();
		Destination destination = session.createQueue("test.queue");
		MessageProducer producer = session.createProducer(destination);
		
		//Creating Message
		TextMessage message = session.createTextMessage(ExpectedText);
		
		//Sending message
		producer.send(message);
		
		//Consuming Message
		MessageConsumer consumer = session.createConsumer(destination);
		Message rm = consumer.receive(100);
		
		//Converting message back
		TextMessage receivedMessage = (TextMessage) rm;
		String receivedText = receivedMessage.getText();
		
		//Asserting
		Assert.assertEquals(ExpectedText, receivedText);
	}
}
