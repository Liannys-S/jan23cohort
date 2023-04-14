package com.dojo.bookclub.models;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotBlank;

public class LogUser {

	@NotBlank(message="Email is required!")
	@Email(message="Please enter a valid email!")
	private String logEmail;
	
	@NotBlank(message="Password is required!")
	private String logPassword;
	
	public LogUser() {}

	public String getLogEmail() {
		return logEmail;
	}

	public void setLogEmail(String logEmail) {
		this.logEmail = logEmail;
	}

	public String getLogPassword() {
		return logPassword;
	}

	public void setLogPassword(String logPassword) {
		this.logPassword = logPassword;
	}
	
}
