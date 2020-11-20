package com.tamagotchi.clock.api;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.client.discovery.EnableDiscoveryClient;

@SpringBootApplication
@EnableDiscoveryClient
public class TamagotchiClockApiApplication {

	public static void main(String[] args) {
		SpringApplication.run(TamagotchiClockApiApplication.class, args);
	}

}
