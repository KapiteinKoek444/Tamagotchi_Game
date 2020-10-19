package com.tamagotchi.shop.repository;

import org.springframework.data.mongodb.repository.MongoRepository;

import com.tamagotchi.shop.model.Food;

public interface FoodRepository extends MongoRepository<Food, String>{
	
}
