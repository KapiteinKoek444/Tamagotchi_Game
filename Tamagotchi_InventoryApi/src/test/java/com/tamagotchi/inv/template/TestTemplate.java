package com.tamagotchi.inv.template;

import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

import com.tamagotchi.inv.TamagotchiInventoryApiApplication;

@RunWith(SpringJUnit4ClassRunner.class)
@SpringBootTest(
        classes = TamagotchiInventoryApiApplication.class)
public abstract class TestTemplate {

	protected Logger logger = LoggerFactory.getLogger(this.getClass());
	
}
