import java.util.ArrayList;
public class TestOrders {
    public static void main(String[] args) {
        //create order objects
        Order order1 = new Order();
        Order order2 = new Order();
        Order order3 = new Order("Liannys");
        Order order4 = new Order("Joslyn");
        Order order5 = new Order("Emily");

        //create item objects
        Item item1 = new Item("Drip Coffee", 1.5);
        Item item2 = new Item("Cappuccino", 3.5);
        Item item3 = new Item("Latte", 3);
        Item item4 = new Item("Frappe", 4.5);

        //add items to order list
        order1.addItem(item3);
        order1.addItem(item4);
    
        order2.addItem(item1);
        order2.addItem(item4);
    
        order3.addItem(item1);
        order3.addItem(item2);
    
        order4.addItem(item3);
        order4.addItem(item2);
    
        order5.addItem(item1);
        order5.addItem(item3);
    
        // set ready status for some orders
        order2.setIsReady(true);
        order3.setIsReady(true);
        order4.setIsReady(true);

        // display status message 
        System.out.println(order1.getStatusMessage());
        System.out.println(order2.getStatusMessage());
        System.out.println(order3.getStatusMessage());
        System.out.println(order4.getStatusMessage());
        System.out.println(order5.getStatusMessage());

        //testing get total
        System.out.println(order1.getOrderTotal());
        System.out.println(order2.getOrderTotal());
        System.out.println(order3.getOrderTotal());
        System.out.println(order4.getOrderTotal());
        System.out.println(order5.getOrderTotal());

        //testing display method
        order1.display();
        order2.display();
        order3.display();
        order4.display();
        order5.display();
    }
}
