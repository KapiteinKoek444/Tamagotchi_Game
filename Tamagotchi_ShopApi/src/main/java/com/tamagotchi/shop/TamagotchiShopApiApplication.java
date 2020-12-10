package com.tamagotchi.shop;

import java.net.URI;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import com.mongodb.annotations.Immutable;

@SpringBootApplication
public class TamagotchiShopApiApplication {

	public static void main(String[] args) {
		SpringApplication.run(TamagotchiShopApiApplication.class, args);
	}
	
}
