package classes;

public class Sculpture extends Art {
	
	private String material;

	public Sculpture(String title, String author, String description, String material) {
		super(title, author, description);
		this.material = material;
	}

	@Override
	public void viewArt() {
		System.out.printf("Title : %s%nAuthor : %s%nDescription : %s%nMaterial : %s%n", this.title, this.author, this.description, this.material);
	}

	public String getMaterial() {
		return material;
	}

	public void setMaterial(String material) {
		this.material = material;
	}


}
