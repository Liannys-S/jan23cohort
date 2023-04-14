package com.dojo.studentroster.controllers;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.dojo.studentroster.models.Student;
import com.dojo.studentroster.services.DormService;
import com.dojo.studentroster.services.StudentService;

@Controller
@RequestMapping("/students")
public class StudentController {
	@Autowired
	StudentService service;
	
	@Autowired
	DormService dormService;
	
	@GetMapping("/new")
	public String newStudent(@ModelAttribute("student") Student student, Model model) {
		model.addAttribute("allDorms", dormService.allDorms());
		return "newStudent.jsp";
	}
	
	@PostMapping("/create")
	public String createStudent(@Valid @ModelAttribute("student") Student student, BindingResult result, Model model) {
		if(result.hasErrors()) {
			model.addAttribute("allDorms", dormService.allDorms());
			return "newStudent.jsp";
		}
		service.createStudent(student);
		return "redirect:/";
	}
}
