package com.tamagotchi.shop.repository;

import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.config.EnableMongoRepositories;

import com.tamagotchi.shop.model.Food;

@EnableMongoRepositories
public interface FoodRepository extends MongoRepository<Food, String>{
	
}
