package com.tamagotchi.inv.service;

import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.tamagotchi.inv.model.Inventory;
import com.tamagotchi.inv.repository.InventoryRepository;

@RestController
@RequestMapping("/Rest")
public class InventoryRestController {
	@Autowired
	private InventoryRepository repository;
	
	@GetMapping("/GetInventory/{id}")
	public Optional<Inventory> GetInventory(@PathVariable String id) {
		return repository.findById(id);
	}
	
	@PostMapping("/AddInventory")
	public void AddInventory(@RequestBody Inventory inv) {
		repository.save(inv);
	}
	
	@PostMapping("/UpdateInventory")
	public void UpdateInventory(@RequestBody Inventory newInv) {
		repository.save(newInv);
	}
}
