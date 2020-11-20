package com.tamagotchi.databuilder;

import com.tamagotchi.shop.model.Food;
import com.tamagotchi.shop.model.ModelFood;

public class Food_Factory {
	
	
	public Food GenerateFood() {
		Food food = new Food();
		food.id = "5a5f49cf-0618-4052-9fb9-6441fe9dea3b";
		food.name = "whinegums";
		food.category = "candy";
		food.price = 1.70;
		food.discount = 0;
		food.energyVal = 4;
		food.happyVal = 1;
		food.foodVal = 8;
		
		return food;
	}
}
