package com.tamagotchi.clock.api.model;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString

public class UserResponse {
    public String content;
    
    public UserResponse(String content) {
    	this.content = content;
    }
}
