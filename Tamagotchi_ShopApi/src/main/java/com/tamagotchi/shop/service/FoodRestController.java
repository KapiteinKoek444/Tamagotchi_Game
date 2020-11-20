package com.tamagotchi.shop.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.tamagotchi.shop.model.Food;
import com.tamagotchi.shop.repository.FoodRepository;

@RestController
@RequestMapping("/Rest")
public class FoodRestController {

	@Autowired
	private FoodRepository repository;
	
	@GetMapping("/GetAllFood")
	public List<Food> GetAllFood() {
		return repository.findAll();
	}

	@GetMapping("/GetFood/{id}")
	public Food GetFood(@PathVariable String id) {
		return repository.findById(id).orElse(null);
	}

	@PostMapping("/AddFood")
	public void AddFood(@RequestBody Food food) {
		repository.save(food);
	}
	
	public void RemoveFood(Food food) {
		repository.delete(food);
	}
}
