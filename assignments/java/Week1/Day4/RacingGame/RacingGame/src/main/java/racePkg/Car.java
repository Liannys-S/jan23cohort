package racePkg;

public class Car {
	//attributes
	protected int gas;
	
	//constructor
	public Car() {
		gas = 10;
	}
	
	//methods
	public void status() {
		System.out.println("Current gas: " + gas);
	}
	
	//setters and getters
	public int getGas() {
		return gas;
	}
	public void setGas(int gas) {
		this.gas = gas;
	}
}
