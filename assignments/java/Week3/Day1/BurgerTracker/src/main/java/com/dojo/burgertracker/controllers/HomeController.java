package com.dojo.burgertracker.controllers;

import java.util.List;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;

import com.dojo.burgertracker.models.Burger;
import com.dojo.burgertracker.services.BurgerService;

@Controller
public class HomeController {
	
	@Autowired
	BurgerService burgerService;
	
	@GetMapping("/burgers")
	public String newBurger(@ModelAttribute("burger") Burger burger, Model model) {
		List<Burger> allBurgers = burgerService.allBurgers();
		model.addAttribute("allBurgers", allBurgers);
		return "index.jsp";
	}
	
	@PostMapping("/burgers/create")
	public String createBurger(@Valid @ModelAttribute("burger") Burger burger, BindingResult result, Model model) {
		if(result.hasErrors()) {
			List<Burger> allBurgers = burgerService.allBurgers();
			model.addAttribute("allBurgers", allBurgers);
			return "index.jsp";
		}
		burgerService.createBurger(burger);
		return "redirect:/burgers";
	}
	
	@GetMapping("/burgers/edit/{id}")
	public String edit(@PathVariable(value="id") Long id, Model model) {		
		model.addAttribute("burger", burgerService.findBurger(id));
		return "edit.jsp";
	}
	
	@PutMapping("/burgers/update/{id}")
	public String update(@PathVariable(value="id") Long burgerId, Model model,  @Valid @ModelAttribute("burger") Burger burger , BindingResult result) {
		if(result.hasErrors()) {
			return "edit.jsp";
		}else {
			burgerService.updateBurger(burger);
			return "redirect:/burgers";			
		}
	}
    @DeleteMapping("/burgers/delete/{id}")
    public String deleteBurger(@PathVariable("id") Long id) {
        burgerService.deleteBurger(id);
        return "redirect:/burgers";
    }


}
