import java.util.ArrayList;

public class Order {
    
    private String name;
    private boolean isReady;
    private ArrayList<Item> items;

    public Order(){
        name = "Guest";
        items = new ArrayList<>();
    }
    public Order(String name){
        this.name = name;
        items = new ArrayList<>();
    }

    public String getName(){
        return name;
    }
    public void setName(String name){
        this.name = name;
    }
    
    public boolean getIsReady(){
        return isReady;
    }
    public void setIsReady(boolean isReady){
        this.isReady = isReady;
    }

    public ArrayList<Item> getItems(){
        return items;
    }
    public void setItems(ArrayList<Item> items){
        this.items = items;
    }

    public void addItem(Item item){
        items.add(item);
    }

    public String getStatusMessage(){
        if(isReady){
            return "Your order is ready.";
        }
        return "Thank you for waiting. Your order will be ready soon.";
    }

    public double getOrderTotal(){
        double sum = 0;
        for(Item item : items){
            sum += item.getPrice();
        }
        return sum;
    }

    public void display(){
        System.out.println("Customer Name: " + name);
        for(Item item : items){
            System.out.printf("%s - $%.2f%n",item.getName(),item.getPrice());
        }
        System.out.printf("Total: $%.2f%n", getOrderTotal());
    }
}
