package com.tamagotchi.inv.service;

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
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.transaction.annotation.Transactional;

import com.tamagotchi.inv.model.Inventory;
import com.tamagotchi.inv.model.ModelRequestItemsResponse;
import com.tamagotchi.inv.template.InventoryTemplate;
import com.tamagotchi.inv.template.TestTemplate;

@RunWith(SpringRunner.class)
@Transactional
public class MessageControllerTest extends TestTemplate {
	@Autowired
	private JmsTemplate jmstemplate;
	@Autowired
	private InventoryMessageQueue controller;
	@Autowired
	private InventoryTemplate template;

	private Connection connection;
	private Inventory testInventory;

	@BeforeClass
	public void setUp() throws JMSException {
		testInventory = template.ToAddInventory();

		connection = jmstemplate.getConnectionFactory().createConnection();
		connection.start();
	}

	@AfterClass
	public void tearDown() throws JMSException {
		connection.close();
	}

	@Test
	public void MessageConnectionTest() throws Exception {
		String ExpectedText = "Hello world test!!";

		// Creating session
		Session session = connection.createSession();
		Destination destination = session.createQueue("test.queue");
		MessageProducer producer = session.createProducer(destination);

		// Creating Message
		TextMessage message = session.createTextMessage(ExpectedText);

		// Sending message
		producer.send(message);

		// Consuming Message
		MessageConsumer consumer = session.createConsumer(destination);
		Message rm = consumer.receive(100);

		// Converting message back
		TextMessage receivedMessage = (TextMessage) rm;
		String receivedText = receivedMessage.getText();

		// Asserting
		Assert.assertEquals("failure - got wrong message.", ExpectedText, receivedText);
	}

	@Test
	public void GetFoodTest() throws InterruptedException {
		// Assign
		Inventory inventory = testInventory;
		String foodid = testInventory.itemId.get(0);

		// Act
		ModelRequestItemsResponse response = controller.GetALLItems(inventory.id);

		// Assert
		Assert.assertNotNull("failed - invalid response", response);
		Assert.assertEquals("failed - id's do not match", foodid, response.Items.get(0).id);
	}

}
