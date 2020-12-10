package com.tamagotchi.bank.template;

import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

import com.tamagotchi.bank.TamagotchiBankApiApplication;

@RunWith(SpringJUnit4ClassRunner.class)
@SpringBootTest(
        classes = TamagotchiBankApiApplication.class)
public abstract class TestTemplate {

	protected Logger logger = LoggerFactory.getLogger(this.getClass());
	
}
