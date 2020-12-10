package com.tamagotchi.shop.service;

import java.util.Collection;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.junit4.SpringRunner;

import com.tamagotchi.shop.model.Food;
import com.tamagotchi.shop.template.TestTemplate;

@RunWith(SpringRunner.class)
public class RestControllerTest extends TestTemplate{

	@Autowired(required = true)
	private FoodRestController controller;
	
	@Autowired(required = true)
	private FoodTemplate template;
	
	private Food toRemoveFood;
	private Food toAddFood;
	
	@Before
	public void setUp() {
		toRemoveFood = template.ToRemoveFood();
		controller.AddFood(toRemoveFood);
	}
	
	@After
	public void tearDown() {
		//Removing food;
		controller.RemoveFood(toAddFood);
		controller.RemoveFood(toRemoveFood);
	}
	
	@Test
	public void GetAllTest() {
		//Assign
		Collection<Food> foodList;
		
		//Act
		foodList = controller.GetAllFood();
		
		//Assert
		Assert.assertNotNull("failure - expected empty list.", foodList);
	}
	
	@Test
	public void AddTest() {
		//Assign
		toAddFood = template.ToAddFood();
		
		//Act
		String id = controller.AddFood(toAddFood);
		
		//Assert
		Assert.assertNotNull("failure - Food could not be added.", toAddFood);
		Assert.assertEquals("failure - could not be added or could not be found.", toAddFood.id, id);
	}
	
	@Test
	public void GetFood() {
		//Assign
		String TestFoodid = toRemoveFood.id;
		//Act
		Food assertFood = controller.GetFood(TestFoodid);
		
		//Assert
		Assert.assertNotNull("failure - could not get food.", assertFood);
		Assert.assertEquals("failure - got wrong food.", assertFood, toRemoveFood);
	}
	
	@Test
	public void RemoveTest() {
		//Assign
		String TestFoodid = toRemoveFood.id;
		
		//Act
		Food testfood = controller.GetFood(TestFoodid);
		
		controller.RemoveFood(testfood);
		
		Food assertedfood = controller.GetFood(TestFoodid);
		
		//Assert
		Assert.assertNull("failure - unable to remove food.", assertedfood);
	}
}
