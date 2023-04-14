package com.dojo.logreg.services;

import java.util.List;
import java.util.Optional;

import org.mindrot.jbcrypt.BCrypt;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.validation.BindingResult;

import com.dojo.logreg.models.LogUser;
import com.dojo.logreg.models.User;
import com.dojo.logreg.repositories.UserRepo;

@Service
public class UserServices {
	@Autowired
	private UserRepo repo;
	
	public User register(User newUser, BindingResult result) {
		if(result.hasErrors()) {
			return null;
		}
		
		Optional<User> u = repo.findByEmail(newUser.getEmail());
		
		if(u.isPresent()) {
			result.rejectValue("email", "email", "Email is already registered!");
			return null;
		}
		
		if(!newUser.getPassword().equals(newUser.getConfirmPassword())) {
			result.rejectValue("confirmPassword", "password", "Passwords do not match!");
			return null;
		}
		
		String hashedPW = BCrypt.hashpw(newUser.getPassword(), BCrypt.gensalt());
		newUser.setPassword(hashedPW);
		return repo.save(newUser);
	}
	
	public User login(LogUser newLog, BindingResult result) {
		if(result.hasErrors()) {
			return null;
		}
		Optional<User> u = repo.findByEmail(newLog.getLogEmail());
		if(!u.isPresent()) {
			result.rejectValue("logEmail", "email", "Email not found!");
			return null;
		}
		
		if(!BCrypt.checkpw(newLog.getLogPassword(),u.get().getPassword())) {
			result.rejectValue("logPassword", "password", "Invalid Password!");
			return null;
		}
		return u.get();
	}
	
	public List<User> getAllUsers(){
		return repo.findAll();
	}
	
	public User getUser(Long id) {
		return repo.findById(id).orElse(null);
	}
	
}
