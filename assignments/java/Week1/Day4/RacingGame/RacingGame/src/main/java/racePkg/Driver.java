package racePkg;

public class Driver extends Car {

	//methods
	public void drive() {
		gas -= 1;
		System.out.println("You drive the car.\nGas remaining: " + gas);
		if(gas == 0) {
			System.out.println("Game Over");			
		}
	}
	
	public void booster() {
		if(gas < 3) {
			System.out.println("Cannot boost. Current gas is: " + gas);
			return;
		}
		gas -= 3;
		System.out.println("You used the boost.\nGas remaining: " + gas);
		if(gas == 0) {
			System.out.println("Game Over");			
		}
	}
	
	public void refuel() {
		if(gas > 8) {
			System.out.println("Cannot refuel. Current gas is: " + gas);
			return;
		}
		gas += 2;
		System.out.println("You refuled the car.\nGas remaining: " + gas);
	}
}
