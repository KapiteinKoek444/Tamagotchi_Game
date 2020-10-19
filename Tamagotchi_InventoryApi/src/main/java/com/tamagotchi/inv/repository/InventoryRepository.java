package com.tamagotchi.inv.repository;

import org.springframework.data.mongodb.repository.MongoRepository;

import com.tamagotchi.inv.model.Inventory;

public interface InventoryRepository extends MongoRepository<Inventory, String>{

}
