package com.tamagotchi.shop.model;

import org.springframework.data.mongodb.core.mapping.Document;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

@Document(collection = "Food")
public class Food extends Item{

	public String category;
	
	public double foodVal;
	public double energyVal;
	public double happyVal;
}
