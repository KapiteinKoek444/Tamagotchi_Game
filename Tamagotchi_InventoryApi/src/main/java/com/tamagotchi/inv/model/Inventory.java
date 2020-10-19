package com.tamagotchi.inv.model;

import java.util.List;

import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

@Document(collection="Inventory")
public class Inventory {
	
	@Id
	public String id;
	public String userId;
	
	
	public List<String> items;
	
}
