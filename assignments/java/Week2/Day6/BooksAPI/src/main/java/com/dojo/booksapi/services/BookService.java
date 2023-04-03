package com.dojo.booksapi.services;

import java.util.List;
import java.util.Optional;

import org.springframework.stereotype.Service;

import com.dojo.booksapi.models.Book;
import com.dojo.booksapi.repositories.BookRepository;

@Service
public class BookService {

	// adding the book repository as a dependency
	private final BookRepository bookRepository;
	
	public BookService(BookRepository bookRepository) {
		this.bookRepository = bookRepository;
	}
	
	// returns all books
	public List<Book> allBooks(){
		return bookRepository.findAll();
	}
	
	//creates a book
	public Book createBook(Book b) {
		return bookRepository.save(b);
	}
	
	//updates book, same as createBook method
	//looks up object by id and then updates. if not found, creates new book
	public Book updateBook(Long id, String title, String description, String language, int numOfPages) {
		Book book = findBook(id);
		if(book == null) {
			book = new Book(title, description, language, numOfPages);
		}else {
			book.setTitle(title);
			book.setDescription(description);
			book.setLanguage(language);
			book.setNumberOfPages(numOfPages);
		}
		return bookRepository.save(book);
	}

	
	//retrieves a book
	public Book findBook(Long id) {
		Optional<Book> optionalBook = bookRepository.findById(id);
		if(optionalBook.isPresent()) {
			return optionalBook.get();
		}else {
			return null;
		}
	}
	
	//deletes a book
	public void deleteBook(Long id) {
		bookRepository.deleteById(id);
	}
}
