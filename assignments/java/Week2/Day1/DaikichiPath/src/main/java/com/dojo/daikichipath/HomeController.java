package com.dojo.daikichipath;

import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/daikichi")
public class HomeController {

	@RequestMapping("/travel/{location}")
	public String travel(@PathVariable("location") String location) {
		return "Congragulations! You will soon travel to " + location + "!";
	}

	@RequestMapping("/lotto/{number}")
	public String lotto(@PathVariable("number") int number) {
		if (number % 2 == 0) {
			return "You will take a grand journey in the near future, but be wary of tempting offers";
		}
		if (number % 2 == 1) {
			return "You have enjoyed the fruits of your labor but now is a great time to spend time with family and friends.";
		}
		return "That is not a number, no luck for you...";
	}
}
