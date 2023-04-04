package com.dojo.burgertracker.services;

import java.util.List;
import java.util.Optional;

import org.springframework.stereotype.Service;

import com.dojo.burgertracker.models.Burger;
import com.dojo.burgertracker.repositories.BurgerRepository;

@Service
public class BurgerService {
	
	private final BurgerRepository burgerRepository;
	
	public BurgerService(BurgerRepository burgerRepository) {
		this.burgerRepository = burgerRepository;
	}
	
	//returns all burgers
	public List<Burger> allBurgers(){
		return burgerRepository.findAll();
	}
	
	//creates a burger
	public Burger createBurger(Burger b) {
		return burgerRepository.save(b);
	}
	
	//updates a burger
	public Burger updateBurger(Burger b) {
		return burgerRepository.save(b);
	}
	
	//find a burger
	public Burger findBurger(Long id) {
		Optional<Burger> optionalBurger = burgerRepository.findById(id);
		if(optionalBurger.isPresent()) {
			return optionalBurger.get();
		}
		return null;
	}
	
	//delete a burger
	public void deleteBurger(Long id) {
		burgerRepository.deleteById(id);
	}
}
