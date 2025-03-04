package com.dojo.studentroster.repositories;

import java.util.List;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.dojo.studentroster.models.Dorm;

@Repository
public interface DormRepo extends CrudRepository<Dorm, Long> {
	List<Dorm> findAll();
}
