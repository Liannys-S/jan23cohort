package com.dojo.logreg.controllers;

import javax.servlet.http.HttpSession;
import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;

import com.dojo.logreg.models.LogUser;
import com.dojo.logreg.models.User;
import com.dojo.logreg.services.UserServices;

@Controller
public class HomeController {
	@Autowired
	UserServices service;
	
	@GetMapping("/")
	public String index(@ModelAttribute("user") User user, @ModelAttribute("logUser") LogUser logUser) {
		return "index.jsp";
	}
	
	@PostMapping("/register")
	public String register(@Valid @ModelAttribute("user") User user, BindingResult result, @ModelAttribute("logUser") LogUser logUser, HttpSession session) {
		service.register(user, result);
		if(result.hasErrors()) {
			return "index.jsp";
		}
		session.setAttribute("UUID",user.getId());
		return "redirect:/welcome";
	}
	
	@PostMapping("/login")
	public String login(@Valid @ModelAttribute("logUser") LogUser logUser, BindingResult result, @ModelAttribute("user") User user, HttpSession session) {
		User u = service.login(logUser, result);
		if(result.hasErrors()) {
			return "index.jsp";
		}
		session.setAttribute("UUID",u.getId());
		return "redirect:/welcome";
	}
	
	@GetMapping("/welcome")
	public String welcome(HttpSession session, Model model ) {
		if(session.getAttribute("UUID") == null) {
			return "redirect:/";
		}
		model.addAttribute("user", service.getUser((Long)session.getAttribute("UUID")));
		return "welcome.jsp";
	}
	
	@GetMapping("/logout")
	public String logout(HttpSession session) {
		session.invalidate();
		return "redirect:/";
	}
}
