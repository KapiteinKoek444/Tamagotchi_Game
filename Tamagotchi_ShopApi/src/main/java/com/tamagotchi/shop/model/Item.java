package com.tamagotchi.shop.model;

import org.springframework.data.annotation.Id;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

public class Item {
	@Id
	public String Id;
	public String name;
	
	public double price;
	public double discount;
}
