package com.tamagotchi.shop.service;

import org.springframework.stereotype.Service;

import com.tamagotchi.shop.model.Food;

@Service
public class FoodTemplate {
	public Food ToAddFood() {
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
	
	public Food ToRemoveFood() {
		Food food = new Food();
		food.id = "63474101-0c1c-441a-a78e-7bcc8dbc1ce4";
		food.name = "testfood";
		food.category = "testing";
		food.price = 1.70;
		food.discount = 0;
		food.energyVal = 4;
		food.happyVal = 1;
		food.foodVal = 8;
		
		return food;
	}
}
