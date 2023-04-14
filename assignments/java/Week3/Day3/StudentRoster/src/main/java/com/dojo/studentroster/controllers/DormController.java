package com.dojo.studentroster.controllers;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.dojo.studentroster.models.Dorm;
import com.dojo.studentroster.services.DormService;
import com.dojo.studentroster.services.StudentService;

@Controller
@RequestMapping("/dorms")
public class DormController {
	@Autowired
	DormService service;
	@Autowired
	StudentService studentService;
	
	@GetMapping("")
	public String displayAll(Model model) {
		model.addAttribute("allDorms", service.allDorms());
		return "index.jsp";
	}
	
	@GetMapping("/new")
	public String newDorm(@ModelAttribute("dorm") Dorm dorm) {
		return "newDorm.jsp"; 
	}
	
	@PostMapping("/create")
	public String createDorm(@Valid @ModelAttribute("dorm") Dorm dorm, BindingResult result) {
		if(result.hasErrors()) {
			return "newDorm.jsp";
		}
		service.createDorm(dorm);
		return "redirect:/";
	}
	
	@GetMapping("/{id}")
	public String viewOne(@PathVariable("id") Long id, Model model) {
		Dorm viewDorm = service.findDorm(id);
		if(viewDorm == null) {
			return "redirect:/";
		}
		model.addAttribute("dorm", viewDorm);
		model.addAttribute("allStudents", studentService.allStudents());
		return "viewDorm.jsp";
	}
}
