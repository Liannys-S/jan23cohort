package com.codingdojo.zookeeper.models;

public class Gorilla extends Mammal {
	//methods
	public void throwSomething() {
		this.setEnergyLevel(this.getEnergyLevel()- 5);
		System.out.println("Gorilla has thrown an object, it's energy level is now: " + this.getEnergyLevel());
	}

	public void eatBananas() {
		this.setEnergyLevel(this.getEnergyLevel()+ 10);
		System.out.println("Gorilla has eaten a banana, it's energy level is now: " + this.getEnergyLevel());
	}
	
	public void climb() {
		this.setEnergyLevel(this.getEnergyLevel()- 10);
		System.out.println("Gorilla has climbed a tree, it's energy level is now: " + this.getEnergyLevel());
	}
	

	
}
