
import java.util.ArrayList;
import java.util.Random;
public class TestPuzzle{
    
	public static void main(String[] args) {
		PuzzleJava generator = new PuzzleJava();
		ArrayList<Integer> randomRolls = generator.getTenRolls();
		System.out.println(randomRolls);
        
        System.out.println("-----------------------");
        char randomLetter = generator.getRandomLetter();
        System.out.println(randomLetter);
        
        System.out.println("-----------------------");
        String randomPassword = generator.generatePassword();
        System.out.println(randomPassword);
        
        System.out.println("-----------------------");
        String[] passwordSet = generator.getNewPasswordSet(5);
        for(String password : passwordSet){
            System.out.println(password);
        }

        System.out.println("-----------------------");
        Integer[] someIntArr = {1,2,3,4,5};
        someIntArr = generator.shuffleArray(someIntArr);
        for(Integer num : someIntArr){
            System.out.print(num + " ");
        }
	}
}
