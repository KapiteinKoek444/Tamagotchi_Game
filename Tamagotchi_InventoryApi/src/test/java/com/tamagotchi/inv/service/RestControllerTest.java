package com.tamagotchi.inv.service;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.junit4.SpringRunner;
import org.springframework.transaction.annotation.Transactional;

import com.tamagotchi.inv.model.Inventory;
import com.tamagotchi.inv.template.InventoryTemplate;
import com.tamagotchi.inv.template.TestTemplate;

@RunWith(SpringRunner.class)
@Transactional
public class RestControllerTest extends TestTemplate {

	@Autowired
	private InventoryRestController controller;

	@Autowired
	private InventoryTemplate template;

	private Inventory toRemoveInv;
	private Inventory toUpdateInv;
	private Inventory toAddInv;

	@Before
	public void setUp() {
		toRemoveInv = template.ToRemoveInventory();
		toUpdateInv = template.ToUpdateInventory();
		toAddInv = template.ToAddInventory();
		
		controller.AddInventory(toRemoveInv);
	}

	@After
	public void tearDown() {
		// Removing food;
		controller.RemoveInventory(toAddInv.id);
		controller.RemoveInventory(toRemoveInv.id);
	}

	@Test
	public void AddInventoryTest() {
		// Assign
		Inventory assignedInv = toAddInv;

		// Act
		controller.AddInventory(assignedInv);
		Inventory assertInv = controller.GetInventory(assignedInv.id);

		// Assert
		Assert.assertNotNull("failed - unable to add inv.", assertInv);
		Assert.assertEquals("failed - inventory was not the same.", assignedInv, assertInv);

	}
	
	@Test
	public void GetInventoryTest() {
		//Assign
		Inventory expectedInv = toRemoveInv;
		Inventory assertInv;
		//Act
		assertInv = controller.GetInventory(toRemoveInv.id);
		//Assert
		
		Assert.assertNotNull("failed - unable to get inv.", assertInv);
		Assert.assertEquals("failed - inventory was not the same.", assertInv, expectedInv);
	}
	
	@Test
	public void UpdateInventoryTest() {
		//Assign
		Inventory expectedInv = toUpdateInv;
		Inventory assertInv;
		//Act
		assertInv = controller.UpdateInventory(expectedInv);
		//Assert
		Assert.assertNotEquals("failed - unable to update inv.", assertInv, toRemoveInv);
		Assert.assertEquals("failed - inventory was not the same.", assertInv, expectedInv);
		
	}
	
	@Test
	public void RemoveInventoryTest() {
		//Assign
		Inventory expectedInv = toRemoveInv;
		Inventory assertInv;
		//Act
		controller.RemoveInventory(expectedInv.id);
		assertInv = controller.GetInventory(expectedInv.id);
		//Assert
		Assert.assertNull("failed - unable to remove inv.", assertInv);
	}

}
