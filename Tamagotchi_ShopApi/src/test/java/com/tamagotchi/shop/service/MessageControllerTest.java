package com.tamagotchi.shop.service;

import javax.jms.Connection;
import javax.jms.Destination;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageConsumer;
import javax.jms.MessageProducer;
import javax.jms.Session;
import javax.jms.TextMessage;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jms.core.JmsTemplate;
import org.springframework.test.context.junit4.SpringRunner;

import com.tamagotchi.shop.model.ModelBankFood;
import com.tamagotchi.shop.model.ModelItem;
import com.tamagotchi.shop.template.TestTemplate;

@RunWith(SpringRunner.class)
public class MessageControllerTest extends TestTemplate {
	
	
	@Autowired(required = true)
	private JmsTemplate jmstemplate;
	@Autowired(required = true)
	private FoodMessageQueueController controller;

	private Connection connection;

	@Before
	public void setUp() throws JMSException {
		connection = jmstemplate.getConnectionFactory().createConnection();
		connection.start();
	}

	@After
	public void tearDown() throws JMSException {
		connection.close();
	}

	@Test
	public void MessageConnectionTest() throws Exception {
		String ExpectedText = "Hello world test!!";

		// Creating session at queue test.queue
		Session session = connection.createSession();
		Destination destination = session.createQueue("test.queue");
		MessageProducer producer = session.createProducer(destination);

		// Creating message
		TextMessage message = session.createTextMessage(ExpectedText);

		// Sending message
		producer.send(message);

		// Getting message back from queue
		MessageConsumer consumer = session.createConsumer(destination);
		Message rm = consumer.receive(100);

		// Converting message back
		TextMessage receivedMessage = (TextMessage) rm;
		String receivedText = receivedMessage.getText();

		// Asserting
		Assert.assertEquals("failure - got wrong message.", ExpectedText, receivedText);
	}

	@Test
	public void buyFoodTest() throws JMSException {
		// Assign
		String id = "0";
		String userId = "1";

		Session session = connection.createSession();
		Destination destination = session.createQueue("buyfoodsend.queue");
		MessageConsumer consumer = session.createConsumer(destination);
		ModelBankFood expectedModel = new ModelBankFood();
		expectedModel.itemId = id;
		expectedModel.userId = userId;

		// Act
		controller.BuyFood(id, userId);

		Message rm = consumer.receive(100);
		ModelBankFood receivedMessage = (ModelBankFood) rm;

		// Assert
		Assert.assertNull("failed - unable to get item.", receivedMessage.itemId);
		Assert.assertEquals("failed - user id failed, got wrong user.", expectedModel.userId, receivedMessage.userId);
		Assert.assertNull("failed - ?", receivedMessage.affordable);
	}

	@Test
	public void awaitBankConfirmationTrue() {
		// Assign
		ModelBankFood confirmationModel = new ModelBankFood();
		confirmationModel.affordable = true;
		String confirmationMessage = "Succesfully bought item!!";

		// Act
		String receivedMessage = controller.AwaitbankConfirmation(confirmationModel);

		// Assert
		Assert.assertNotNull("failed - ?", receivedMessage);
		Assert.assertEquals("failed - received wrong message", confirmationMessage, receivedMessage);
	}

	@Test
	public void awaitBankConfirmationFalse() {
		// Assign
		ModelBankFood confirmationModel = new ModelBankFood();
		confirmationModel.affordable = false;
		String confirmationMessage = "Error, not enough funds";

		// Act
		String receivedMessage = controller.AwaitbankConfirmation(confirmationModel);

		// Assert
		Assert.assertNotNull("failed - ?", receivedMessage);
		Assert.assertEquals("failed - received wrong message", confirmationMessage, receivedMessage);
	}

	@Test
	public void awaitInvConfirmationTrue() {
		// Assign
		ModelItem modelItem = new ModelItem();
		modelItem.confirmation = true;
		String expectedConfirmationMessage = "Succesfully added item to inventory!";
		// Act
		String actualConfirmationMessage = controller.AwaitInvConfirmation(modelItem);
		// Assert
		Assert.assertNotNull("failed - ?", actualConfirmationMessage);
		Assert.assertEquals("failed - received wrong message", expectedConfirmationMessage, actualConfirmationMessage);
	}

	@Test
	public void awaitInvConfirmationFalse() {
		// Assign
		ModelItem modelItem = new ModelItem();
		modelItem.confirmation = false;
		String expectedConfirmationMessage = "Failed to add Item to inventory!";
		// Act
		String actualConfirmationMessage = controller.AwaitInvConfirmation(modelItem);
		// Assert
		Assert.assertNotNull("failed - ?", actualConfirmationMessage);
		Assert.assertEquals("failed - received wrong message", expectedConfirmationMessage, actualConfirmationMessage);
	}
}
