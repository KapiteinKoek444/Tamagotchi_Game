package com.tamagotchi.clock.api.model;

import java.time.LocalDateTime;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

public class ClockModel {
	public String userid;
	
	public LocalDateTime creationDate;
	public LocalDateTime loginDate;
	public LocalDateTime elapsedDate;
}
