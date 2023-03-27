package com.codingdojo.zookeeper.models;

public class Bat extends Mammal {
	
	//constructor, set default energy to 300
	public Bat() {
		super();
		this.setEnergyLevel(300);
	}
	
	//methods
	public void fly() {
		this.setEnergyLevel(this.getEnergyLevel() - 50);
		System.out.println("Bat has taken flight, its energy level is now: " + this.getEnergyLevel());
	}

	public void eatHumans() {
		this.setEnergyLevel(this.getEnergyLevel()+ 25);
		System.out.println("Bat has consumed a tasty human, its energy level is now: " + this.getEnergyLevel());
	}
	
	public void attackTown() {
		this.setEnergyLevel(this.getEnergyLevel() - 100);
		System.out.println("Bat terrorized a town, its energy level is now: " + this.getEnergyLevel());
	}
	
}
