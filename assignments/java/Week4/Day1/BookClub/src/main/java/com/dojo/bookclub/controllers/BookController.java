package com.dojo.bookclub.controllers;

import javax.servlet.http.HttpSession;
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
import org.springframework.web.bind.annotation.RequestMapping;

import com.dojo.bookclub.models.Book;
import com.dojo.bookclub.services.BookService;
import com.dojo.bookclub.services.UserService;

@Controller
@RequestMapping("/books")
public class BookController {
	@Autowired
	UserService userService;
	@Autowired 
	BookService service;
	
	
	@GetMapping(" ")
	public String dashboard(HttpSession session, Model model ) {
		if(session.getAttribute("UUID") == null) {
			return "redirect:/";
		}
		model.addAttribute("user", userService.getUser((Long)session.getAttribute("UUID")));
		model.addAttribute("allBooks",service.allBooks());
		return "dashboard.jsp";
	}
	
	@GetMapping("/new")
	public String newBook(@ModelAttribute("book") Book book, HttpSession session) {
		if(session.getAttribute("UUID") == null) {
			return "redirect:/";
		}
		return "newBook.jsp";
	}
	
	@PostMapping("/add")
	public String addBook(@Valid@ModelAttribute("book") Book book, BindingResult result, HttpSession session) {
		if(session.getAttribute("UUID") == null) {
			return "redirect:/";
		}
		if(result.hasErrors()) {
			return "newBook.jsp";
		}
		book.setUser(userService.getUser((Long)session.getAttribute("UUID")));
		service.createBook(book);
		return "redirect:/books";
	}
	
	@GetMapping("/{id}")
	public String viewBook(@PathVariable("id") Long id, Model model, HttpSession session) {
		if(session.getAttribute("UUID") == null) {
			return "redirect:/";
		}
		model.addAttribute("book", service.findBook(id));
		return "viewBook.jsp";
	}
	
	@GetMapping("/{id}/edit")
	public String editBook(@PathVariable("id") Long id, @ModelAttribute("bookForm") Book book, HttpSession session, Model model) {
		if(session.getAttribute("UUID") == null) {
			return "redirect:/";
		}
		
		model.addAttribute("book", service.findBook(id));
		return "editBook.jsp";
	}
	
	@PutMapping("/{id}/update")
	public String updateBook(@PathVariable("id") Long id, @Valid @ModelAttribute("bookForm") Book book, BindingResult result, HttpSession session, Model model) {
		if(result.hasErrors()) {
			model.addAttribute("book",service.findBook(id));
			return "editBook.jsp";
		}
		book.setUser(userService.getUser((Long)session.getAttribute("UUID")));
		service.updateBook(book);
		return "redirect:/books";
	}
	
	@DeleteMapping("/{id}/delete")
	public String deleteBook(@PathVariable("id") Long id, HttpSession session){
		service.deleteBook(id);
		return "redirect:/books";
	}

}
