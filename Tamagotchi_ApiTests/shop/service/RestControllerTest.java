package com.tamagotchi.shop.service;

import java.util.Collection;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.transaction.annotation.Transactional;

import com.tamagotchi.databuilder.Food_Factory;
import com.tamagotchi.shop.model.Food;
import com.tamagotchi.shop.template.TestTemplate;
@Transactional 
@ComponentScan(basePackages = {"com.tamagotchi.shop.service", "com.tamagotchi.shop.model", "com.tamagotchi.shop.repository"})
public class RestControllerTest extends TestTemplate{

	@Autowired
	private FoodRestController controller;
	
	@Autowired 
	private Food_Factory foodfactory;
	
	@Before
	public void setUp() {
		//Setting up tests
	}
	
	@After
	public void tearDown() {
		//cleaning tests after finishes
	}
	
	@Test
	public void GetAllTest() {
		//Assign
		Collection<Food> foodList;
		
		//Act
		foodList = controller.GetAllFood();
		
		//Assert
		Assert.assertNotNull(foodList);
		Assert.assertEquals(2, foodList.size());
	}
	
	@Test
	public void AddandFindTest() {
		//Assign
		Food additionalFood = foodfactory.GenerateFood();
		
		//Act
		controller.AddFood(additionalFood);
		Food assertedFood = controller.GetFood(additionalFood.id);
		
		//Assert
		Assert.assertNotNull(assertedFood);
		Assert.assertEquals(additionalFood, assertedFood);
	}
	
	@Test
	public void RemoveTest() {
		//Assign
		String TestFoodid = foodfactory.GenerateFood().id;
		
		//Act
		Food testfood = controller.GetFood(TestFoodid);
		controller.RemoveFood(testfood);
		Food assertedfood = controller.GetFood(TestFoodid);
		
		//Assert
		Assert.assertNull(assertedfood);
	}
}
