package com.tamagotchi.shop.model;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

public class ModelItem {
	public String userId;
	public String itemId;
	public boolean confirmation;
}
