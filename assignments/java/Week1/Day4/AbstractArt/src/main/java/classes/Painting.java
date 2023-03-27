package classes;

public class Painting extends Art{
	
	private String paintType;
	
	public Painting(String title, String author, String description, String paintType) {
		super(title, author, description);
		this.paintType = paintType;
	}
	
	
	@Override
	public void viewArt() {
		System.out.printf("Title : %s%nAuthor : %s%nDescription : %s%nPaint Type : %s%n", this.title, this.author, this.description, this.paintType);
		
	}

	public String getPaintType() {
		return paintType;
	}

	public void setPaintType(String paintType) {
		this.paintType = paintType;
	}

}
