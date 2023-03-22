public class Item{
    
    private String name;
    private double price;

    public Item(String name, double price){
        this.name = name;
        this.price = price;
    }
    // get and set for name
    public String getName(){
        return name;
    }
    public void setName(String name){
        this.name = name;
    }
    // get and set for price
    public double getPrice(){
        return price;
    }
    public void setPrice(double price){
        this.price = price;
    }
}