package com.tamagotchi.inv.model;

import org.springframework.data.annotation.Id;
import org.springframework.data.mongodb.core.mapping.Document;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

@Document(collection = "Food")
public class Food{
	@Id
	public String id;
	public String name;
	
	public double price;
	public double discount;
	
	public String category;
	
	public double foodVal;
	public double energyVal;
	public double happyVal;
}
