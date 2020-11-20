package com.tamagotchi.clock.api.service;

import org.springframework.messaging.handler.annotation.MessageMapping;
import org.springframework.messaging.handler.annotation.SendTo;
import org.springframework.stereotype.Controller;

import com.tamagotchi.clock.api.model.UserResponse;

@Controller
public class ClockController {
	
	@MessageMapping("/getElapsedTime")
	@SendTo("/topic/getElapsedTime")
	public UserResponse getElapsedTime(String name) {
		return new UserResponse("Hi" + name);
	}
}
