package com.dojo.studentroster.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.dojo.studentroster.models.Dorm;
import com.dojo.studentroster.repositories.DormRepo;

@Service
public class DormService {
	@Autowired
	private DormRepo repo;

	public Dorm createDorm(Dorm d) {
		return repo.save(d);
	}

	public List<Dorm> allDorms() {
		return repo.findAll();
	}

	public Dorm findDorm(Long id) {
		Optional<Dorm> optionalDorm = repo.findById(id);
		if (optionalDorm.isPresent()) {
			return optionalDorm.get();
		}
		return null;
	}
}
