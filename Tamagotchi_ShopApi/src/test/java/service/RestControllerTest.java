package service;

import java.util.Collection;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.transaction.annotation.Transactional;

import com.tamagotchi.shop.model.Food;
import com.tamagotchi.shop.service.FoodRestController;

import shop.TestTemplate;

@Transactional 
public class RestControllerTest extends TestTemplate{

	@Autowired
	private FoodRestController controller;
	
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
		Assert.assertNotNull("failure - expected not null", foodList);
		Assert.assertEquals("failure - expected size", 2, foodList.size());
	}
	
	@Test
	public void AddandFindTest() {
		//Assign
		Food additionalFood = new Food();
		additionalFood.id = "5a5f49cf-0618-4052-9fb9-6441fe9dea3b";
		additionalFood.name = "whinegums";
		additionalFood.category = "candy";
		additionalFood.price = 1.70;
		additionalFood.discount = 0;
		additionalFood.energyVal = 4;
		additionalFood.happyVal = 1;
		additionalFood.foodVal = 8;
		
		//Act
		controller.AddFood(additionalFood);
		Food assertedFood = controller.GetFood(additionalFood.id);
		
		//Assert
		Assert.assertNotNull("failure - Food could not be added", assertedFood);
		Assert.assertEquals("failure - could not be added or could not be fount", additionalFood, assertedFood);
	}
	
	@Test
	public void RemoveTest() {
		//Assign
		String TestFoodid = "5a5f49cf-0618-4052-9fb9-6441fe9dea3b";
		
		//Act
		Food testfood = controller.GetFood(TestFoodid);
		controller.RemoveFood(testfood);
		Food assertedfood = controller.GetFood(TestFoodid);
		
		//Assert
		Assert.assertNull("failure - could not remove item", assertedfood);
	}
}
