
public class Test{
    public static void main(String[] args){
        System.out.println("Hello World");
        int age = 7;
        int age2 = 3;
        String test = "Hello";
        System.out.println(age);
        System.out.print(age + " " + age2);
        System.out.print("\n" + age + " " + age2 + test);
        // System.out.println(hi());
        String name = "Jane";
        String lName = "Doe";
        String full = name + lName;
        // System.out.println(full);
        int[] numArr = {1,2,3,4};
        
        // System.out.println(numArr); prints memory address
        for(int num : numArr){
            System.out.println(num);
        }
    }

    public static String hi(){
        return "Hello" + " hi there" + 5;
    }
}
