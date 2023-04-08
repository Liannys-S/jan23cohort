package com.dojo.dojosninjas.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.dojo.dojosninjas.models.Ninja;
import com.dojo.dojosninjas.repositories.NinjaRepo;

@Service
public class NinjaService {
	@Autowired
	private NinjaRepo repo;

	// returns all ninjas
	public List<Ninja> allNinjas() {
		return repo.findAll();
	}

	// creates a ninja
	public Ninja createNinja(Ninja e) {
		return repo.save(e);
	}

	// find a ninja
	public Ninja findNinja(Long id) {
		Optional<Ninja> optionalNinja = repo.findById(id);
		if (optionalNinja.isPresent()) {
			return optionalNinja.get();
		}
		return null;
	}
}
