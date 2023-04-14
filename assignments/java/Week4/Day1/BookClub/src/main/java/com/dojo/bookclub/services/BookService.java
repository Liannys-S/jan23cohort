package com.dojo.bookclub.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.dojo.bookclub.models.Book;
import com.dojo.bookclub.repositories.BookRepo;

@Service
public class BookService {

	@Autowired
	private BookRepo repo;
	
	public List<Book> allBooks(){
		return repo.findAll();
	}
	
	public Book createBook(Book b) {
		return repo.save(b);
	}
	
	public Book updateBook(Book b) {
		return repo.save(b);
	}
	
	public void deleteBook(Long id) {
		repo.deleteById(id);
	}
	
	public Book findBook(Long id) {
		Optional<Book> b = repo.findById(id);
		if(b.isPresent()) {
			return b.get();
		}
		return null;
	}
}
