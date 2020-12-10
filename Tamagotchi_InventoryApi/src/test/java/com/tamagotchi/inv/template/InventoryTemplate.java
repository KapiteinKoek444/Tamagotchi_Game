package com.tamagotchi.inv.template;

import java.util.ArrayList;

import org.springframework.stereotype.Service;

import com.tamagotchi.inv.model.Inventory;

@Service
public abstract class InventoryTemplate {
	public Inventory ToAddInventory() {
		String itemID = "5fbe35a9f11fad3075e8c9f6";
		
		Inventory inv = new Inventory();
		inv.id = "bf40f351-2f36-4b04-91cf-bf83968ac5e2";
		inv.itemId = new ArrayList<String>();
		inv.itemId.add(itemID);
		inv.userId = "00000000-0000-0000-0000-000000000000";
		
		return inv;
	}

	public Inventory ToRemoveInventory() {
		String itemID = "5fbe35a9f11fad3075e8c9f6";
		
		Inventory inv = new Inventory();
		inv.id = "39706b55-6e96-4ec6-acf2-27ca952a2765";
		inv.itemId = new ArrayList<String>();
		inv.itemId.add(itemID);
		inv.userId = "00000000-0000-0000-0000-000000000000";
		
		return inv;
	}
	
	public Inventory ToUpdateInventory() {
		String itemIDKapsalon = "5fbe35a9f11fad3075e8c9f6";
		String itemIDRedCow = "5fbee983cc12de4f04883df8";
		
		Inventory inv = new Inventory();
		inv.id = "39706b55-6e96-4ec6-acf2-27ca952a2765";
		inv.itemId = new ArrayList<String>();
		inv.itemId.add(itemIDKapsalon);
		inv.itemId.add(itemIDRedCow);
		inv.userId = "00000000-0000-0000-0000-000000000000";
		
		return inv;
	}
}
