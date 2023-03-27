package classes;

import java.util.ArrayList;
import java.util.Collections;

public class Museum {
	private ArrayList<Art> museum;
	
	public Museum() {
		museum = new ArrayList<>();
	}
	
	public void addArt(Art art) {
		museum.add(art);
	}
	
	public void viewAllArt() {
		Collections.shuffle(museum);
		for(Art art : museum) {
			art.viewArt();
			System.out.println("---------------");
		}
	}
}
