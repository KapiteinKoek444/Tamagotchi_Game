package com.tamagotchi.clock.api.config;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Configuration;
import org.springframework.messaging.simp.SimpMessagingTemplate;
import org.springframework.scheduling.annotation.EnableScheduling;
import org.springframework.scheduling.annotation.Scheduled;

import com.tamagotchi.clock.api.model.UserResponse;

@EnableScheduling
@Configuration
public class SchedulerConfig {
	
	@Autowired
    SimpMessagingTemplate template;

    @Scheduled(fixedDelay = 3000)
    public void sendAdhocMessages() {
        template.convertAndSend("/topic/getElapsedTime", new UserResponse("Fixed Delay Scheduler"));
    }
}
