package com.dojo.hellohuman;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HomeController {
	@RequestMapping("/")
	public String hello(@RequestParam(value="name", required=false) String name, String lastName, String times ) {
		String message = "";
		if(times != null) {
			try {
				int num = Integer.parseInt(times);
				for(int i = 0; i < num; i++) {
					if(lastName == null) {
						message += " Hello " + name;
					}else {
						message += " Hello " + name + " " + lastName;
					}
				}
				return message;
			}catch(NumberFormatException ex){
				ex.printStackTrace();
			}			
		}
		
		if(name == null) {
			return "Hello Human";
		}
		if(lastName == null) {
			return "Hello " + name;
		}
		
		return "Hello " + name + " " + lastName;
	}
}
