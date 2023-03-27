package com.racing.demo;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import racePkg.Driver;

@SpringBootApplication
public class RacingGameApplication {

	public static void main(String[] args) {
		
		Driver driver1 = new Driver();
		driver1.drive();
		driver1.drive();
		driver1.drive();
		driver1.drive();
		
		driver1.booster();
		driver1.booster();
		driver1.booster();
		
		driver1.refuel();
		driver1.refuel();
		driver1.refuel();
		driver1.refuel();
		driver1.refuel();
		driver1.refuel();
		
		
		SpringApplication.run(RacingGameApplication.class, args);
	}

}
