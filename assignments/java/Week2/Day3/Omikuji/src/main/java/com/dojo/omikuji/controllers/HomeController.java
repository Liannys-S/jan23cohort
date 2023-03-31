package com.dojo.omikuji.controllers;

import javax.servlet.http.HttpSession;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HomeController {

	@RequestMapping("/")
	public String index() {
		return "index.jsp";
	}

	@PostMapping("/submit")
	public String submit(HttpSession session, @RequestParam(value = "year") int year,
			@RequestParam(value = "city") String city, @RequestParam(value = "person") String person,
			@RequestParam(value = "hobby") String hobby, @RequestParam(value = "animal") String animal,
			@RequestParam(value = "compliment") String compliment) {

		session.setAttribute("year", year);
		session.setAttribute("city", city);
		session.setAttribute("person", person);
		session.setAttribute("hobby", hobby);
		session.setAttribute("animal", animal);
		session.setAttribute("compliment", compliment);
		return "redirect:/show";
	}

	@RequestMapping("/show")
	public String show() {
		return "show.jsp";
	}
}
