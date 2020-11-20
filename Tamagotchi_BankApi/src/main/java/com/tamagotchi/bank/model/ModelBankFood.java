package com.tamagotchi.bank.model;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

public class ModelBankFood {

	public String userId;
	public String itemId;
	public double price;
	public boolean affordable;
}
