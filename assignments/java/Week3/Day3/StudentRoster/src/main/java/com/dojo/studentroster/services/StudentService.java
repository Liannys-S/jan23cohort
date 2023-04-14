package com.dojo.studentroster.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.dojo.studentroster.models.Student;
import com.dojo.studentroster.repositories.StudentRepo;

@Service
public class StudentService {
	@Autowired
	private StudentRepo repo;

	public Student createStudent(Student s) {
		return repo.save(s);
	}

	public List<Student> allStudents() {
		return repo.findAll();
	}

	public Student findStudent(Long id) {
		Optional<Student> optionalStudent = repo.findById(id);
		if (optionalStudent.isPresent()) {
			return optionalStudent.get();
		}
		return null;
	}
	
	public Student updateStudent(Student s) {
		return repo.save(s);
	}
	
	public void deleteStudent(Long id) {
		repo.deleteById(id);
	}
}
