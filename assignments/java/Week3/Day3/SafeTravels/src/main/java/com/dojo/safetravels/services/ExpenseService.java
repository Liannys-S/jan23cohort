package com.dojo.safetravels.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.dojo.safetravels.models.Expense;
import com.dojo.safetravels.repositories.ExpenseRepository;

@Service
public class ExpenseService {
	@Autowired
	private ExpenseRepository expenseRepository;

	// returns all expenses
	public List<Expense> allExpenses() {
		return expenseRepository.findAll();
	}

	// creates an expense
	public Expense createExpense(Expense e) {
		return expenseRepository.save(e);
	}

	// updates an expense
	public Expense updateExpense(Expense e) {
		return expenseRepository.save(e);
	}

	// find an expense
	public Expense findExpense(Long id) {
		Optional<Expense> optionalExpense = expenseRepository.findById(id);
		if (optionalExpense.isPresent()) {
			return optionalExpense.get();
		}
		return null;
	}

	// delete an expense
	public void deleteExpense(Long id) {
		expenseRepository.deleteById(id);
	}
}
