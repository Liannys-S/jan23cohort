
public class Cafe {
    public static void main(String[] args){
            // APP VARIABLES
            // Lines of text that will appear in the app. 
            String generalGreeting = "Welcome to Cafe Java, ";
            String pendingMessage = ", your order will be ready shortly";
            String readyMessage = ", your order is ready";
            String displayTotalMessage = "Your total is $";
            
            // Menu variables (add yours below)
            double mochaPrice = 3.5;
            double dripCoffee = 4.5;
            double latte = 6;
            double cappuccino = 3.29;
        
            // Customer name variables (add yours below)
            String customer1 = "Cindhuri";
            String customer2 = "Sam";
            String customer3 = "Jimmy";
            String customer4 = "Noah";
        
            // Order completions (add yours below)
            boolean isReadyOrder1 = true;
            boolean isReadyOrder2 = true;
            boolean isReadyOrder3 = false;
            boolean isReadyOrder4 = true;
        
            // APP INTERACTION SIMULATION (Add your code for the challenges below)
            // Example:
            System.out.println(generalGreeting + customer1); // Displays "Welcome to Cafe Java, Cindhuri"
            if(isReadyOrder1){
                System.out.println(customer1 + readyMessage + "\n" + displayTotalMessage + dripCoffee);
            }else{
                System.out.println(customer1 + pendingMessage);
            }

            System.out.println(generalGreeting + customer2); // Displays "Welcome to Cafe Java, Cindhuri"
            if(isReadyOrder2){
                System.out.println(customer2 + readyMessage + "\n" + displayTotalMessage + mochaPrice);
            }else{
                System.out.println(customer2 + pendingMessage);
            }

            System.out.println(generalGreeting + customer3); // Displays "Welcome to Cafe Java, Cindhuri"
            if(isReadyOrder3){
                System.out.println(customer3 + readyMessage + "\n" + displayTotalMessage + dripCoffee);
            }else{
                System.out.println(customer3 + pendingMessage);
            }

            System.out.println(generalGreeting + customer4); // Displays "Welcome to Cafe Java, Cindhuri"
            if(isReadyOrder4){
                System.out.println(customer4 + readyMessage + "\n" + displayTotalMessage + cappuccino);
            }else{
                System.out.println(customer4 + pendingMessage);
            }

            System.out.println("customer3: Excuse me you charged me incorrectly, I was supposed to pay $" + latte + " not $" + dripCoffee);
            double difference =  latte - dripCoffee;
            System.out.println("Sorry about that, let me correct that for you");
            System.out.println(difference < 0 ? "We owe you $" + difference* -1 : "Your total is: $"+ difference);
    }        
}
