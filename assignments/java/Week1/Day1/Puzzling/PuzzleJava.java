import java.util.Random;
import java.util.ArrayList;

public class PuzzleJava {
    // Random randMachine = new Random();

    public ArrayList<Integer> getTenRolls(){
        Random rand = new Random();
        ArrayList<Integer> tenRolls = new ArrayList<Integer>();
        for(int i = 0; i < 10; i++){
            tenRolls.add(rand.nextInt(1,21));
        }
        return tenRolls;
    }

    public char getRandomLetter(){
        Random rand = new Random();
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".toCharArray();
        return alphabet[rand.nextInt(alphabet.length)];
    }

    public String generatePassword(){
        String password = "";
        for(int i = 0; i < 8; i++){
            password += getRandomLetter();
        }
        return password;
    }

    public String[] getNewPasswordSet(int length){
        String[] passwords = new String[length];
        for(int i = 0; i < passwords.length; i++){
            passwords[i] = generatePassword();
        }
        return passwords;
    }

    public <E>E[] shuffleArray(E[] someArr){
        Random rand = new Random();
        for(int i = 0; i < 10; i++){
            int randomIndex1 = rand.nextInt(someArr.length);
            int randomIndex2 = rand.nextInt(someArr.length);
            E first = someArr[randomIndex1];
            E second = someArr[randomIndex2];
            someArr[randomIndex1] = second;
            someArr[randomIndex2] = first;
        }
        return someArr;
    }
}
