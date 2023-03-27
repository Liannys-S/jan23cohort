package com.dojo.abstractart;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import classes.Museum;
import classes.Painting;
import classes.Sculpture;

@SpringBootApplication
public class AbstractArtApplication {

	public static void main(String[] args) {
		
		Painting painting1 = new Painting("Mona Lisa", "Leonardo da Vinci", "Something something", "Oil Paint");
		Painting painting2 = new Painting("The Starry Night", "Vincent van Gogh", "Something something", "Oil Paint");
		Painting painting3 = new Painting("The Woman Weeping", "Pablo Picasso", "Something something", "Oil Paint");
		
		Sculpture sculpture1 = new Sculpture("David", "Michelangelo", "Blah blah blah", "Carrara Marble");
		Sculpture sculpture2 = new Sculpture("The Thinker", "Auguste Rodin", "Blah blah blah", "Bronze");
		
		painting1.viewArt();
		System.out.println("-----------------");
		painting2.viewArt();
		System.out.println("-----------------");
		painting3.viewArt();
		System.out.println("-----------------");
		
		
		sculpture1.viewArt();
		System.out.println("-----------------");
		sculpture2.viewArt();
		System.out.println("-----------------");
		
		System.out.println("***********Musem***********");
		Museum museum = new Museum();
		museum.addArt(painting1);
		museum.addArt(painting2);
		museum.addArt(painting3);
		museum.addArt(sculpture1);
		museum.addArt(sculpture2);
		museum.viewAllArt();
		
		
		SpringApplication.run(AbstractArtApplication.class, args);
	}

}
