import java.util.ArrayList;

public class ExceptionsTest {
    public static void main(String[] args) {
        ArrayList<Object> myList = new ArrayList<Object>();
        myList.add("13");
        myList.add("Hello World");
        myList.add(48);
        myList.add("Goodbye World (kinda morbid)");

        for (int i = 0; i < myList.size(); i++) {
            try {
                Integer castedValue = (Integer) myList.get(i);

            } catch (ClassCastException e) {
                System.out.println("Error: cannot cast incompatible types. Index : " + i + " Value : " + myList.get(i));
            }
        }
    }
}