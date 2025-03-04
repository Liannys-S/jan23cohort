package classes;

import java.util.ArrayList;
import java.util.Date;

import interfaces.HIPPACompliantAdmin;
import interfaces.HIPPACompliantUser;

public class AdminUser extends User implements HIPPACompliantUser, HIPPACompliantAdmin {
//... imports class definition...

	// Inside class:
	private Integer employeeID;
	private String role;
	private ArrayList<String> securityIncidents;

	// TO DO: Implement a constructor that takes an ID and a role
	public AdminUser(Integer employeeID, String role) {
		super();
		this.employeeID = employeeID;
		this.id = employeeID;
		this.role = role;
		securityIncidents = new ArrayList<>();
	}
	
	
	// TO DO: Implement HIPAACompliantUser!
	@Override
	public boolean assignPin(int pin) {
		if(pin > 99999 && pin < 1000000) {
			this.pin = pin;
			return true;
		}
		return false;
	}
	

	@Override
	public boolean accessAuthorized(Integer confirmedAuthID) {
		if(confirmedAuthID == this.id) {
			return true;
		}
		this.authIncident();
		return false;
	}
	

	// TO DO: Implement HIPAACompliantAdmin!
	@Override
	public ArrayList<String> reportSecurityIncidents() {
		// TODO Auto-generated method stub
		return securityIncidents;
	}


	public void newIncident(String notes) {
		String report = String.format("Datetime Submitted: %s \n,  Reported By ID: %s\n Notes: %s \n", new Date(),
				this.id, notes);
		securityIncidents.add(report);
	}

	public void authIncident() {
		String report = String.format("Datetime Submitted: %s \n,  ID: %s\n Notes: %s \n", new Date(), this.id,
				"AUTHORIZATION ATTEMPT FAILED FOR THIS USER");
		securityIncidents.add(report);
	}

	

	// TO DO: Setters & Getters

	public Integer getEmployeeID() {
		return employeeID;
	}
	
	public void setEmployeeID(Integer employeeID) {
		this.employeeID = employeeID;
	}
	
	public String getRole() {
		return role;
	}
	
	public void setRole(String role) {
		this.role = role;
	}
	
	public ArrayList<String> getSecurityIncidents() {
		return securityIncidents;
	}
	
	public void setSecurityIncidents(ArrayList<String> securityIncidents) {
		this.securityIncidents = securityIncidents;
	}
}
