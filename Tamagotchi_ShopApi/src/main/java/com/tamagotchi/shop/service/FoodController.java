package com.tamagotchi.shop.service;

import java.net.URL;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.tamagotchi.shop.model.Food;
import com.tamagotchi.shop.repository.FoodRepository;

@RestController
public class FoodController {

	@Autowired
	private FoodRepository repository;
	
	@GetMapping("/BuyFood/{id}")
	public Optional<Food> GetWallet(@PathVariable String id) {
		
		var data = repository.findById(id);
		
		Food food = Gson.fromJson(data.toString(), Food.class);
		
		//Call to bank
		String url = "https://tamagotchi-bankapi.azurewebsites.net/RemoveMoney/" + food.Id + "/" + food.price;
		URL obj = new URL(url);
		
		//Check if call is succesfull
		
		//Call to Inventory
		
		return repository.findById(id);
	}
	
	@GetMapping("/GetFood")
	public List<Food> GetWallet() {
		return repository.findAll();
	}
	
	@PostMapping("/AddFood")
	public String AddFood(@RequestBody Food food) {
		repository.save(food);
		return "Added food: " + food.name;
	}
}
