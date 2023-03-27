package com.codingdojo.zookeeper.models;

public class Mammal {
	//attributes
	private int energyLevel;
	
	//constructor
	public Mammal() {
		energyLevel = 100;
	}
	
	//setter and getter
	public int getEnergyLevel() {
		return energyLevel;
	}

	public void setEnergyLevel(int energyLevel) {
		this.energyLevel = energyLevel;
	}
	
	//methods
	public int displayEnergy() {
		System.out.println("Energy Level: " + energyLevel);
		return energyLevel;
	}
}
