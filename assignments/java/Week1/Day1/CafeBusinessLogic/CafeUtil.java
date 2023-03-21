import java.util.ArrayList;

public class CafeUtil {
    
    public int getStreakGoal(int numWeeks){
        int sum = 0;
        for(int i = 1; i <= numWeeks; i++){
            sum += i;
        }
        return sum;
    }

    public double getOrderTotal(double[] prices){
        double sum = 0;
        for(double price : prices){
            sum += price;
        }
        return sum;
    }

    public void displayMenu(ArrayList<String> menuItems){
        for(int i = 0; i < menuItems.size(); i++){
            System.out.println(i + " : "+ menuItems.get(i));
        }
    }

    public boolean displayMenu(ArrayList<String> menuItems, ArrayList<Double> prices){
        if(menuItems.size() != prices.size()){
            return false;
        }
        for(int i = 0; i < prices.size(); i++){
            System.out.printf("%d %s -- $%.2f%n", i, menuItems.get(i), prices.get(i));
        }
        return true;
    }
    
    public void addCustomer(ArrayList<String> customers){
        System.out.println("Please enter your name:");
        String userName = System.console().readLine();
        System.out.printf("Hello, %s%n!", userName);
        System.out.printf("There are %s people in front of you%n", customers.size());
        customers.add(userName);
        System.out.println(customers);
    }
    
    public void printPriceChart(String product, double price, int maxQuantity){
        System.out.println(product);
        for(int i = 1; i<= maxQuantity; i++){
            System.out.printf("%d - $%.2f%n", i, (price*i - .5*(i-1)));
        }
    }
    
    public void addCustomers(ArrayList<String> customers){
        
        String userName = "";
        while(!userName.equals("q")){
            System.out.println("Please enter your name:");
            userName = System.console().readLine();
            if(!userName.equals("q")){
                customers.add(userName);
            }
        }
        System.out.println(customers);
    }
}
