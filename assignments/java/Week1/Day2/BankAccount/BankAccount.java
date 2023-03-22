import java.util.Random;

public class BankAccount {

    private double checkingBalance;
    private double savingsBalance;
    private String accountNumber;
    public static int accountsCreated;
    public static double totalMoneyStored;

    public BankAccount(double checking, double savings){
        checkingBalance = checking;
        savingsBalance = savings;
        accountNumber = generateAccountNumber();
        accountsCreated++;
        totalMoneyStored = checkingBalance + savingsBalance;
    }
    public BankAccount(){
        accountNumber = generateAccountNumber();
        accountsCreated++;
    }

    public double getCheckingBalance(){
        return checkingBalance;
    }
    public double getSavingsBalance(){
        return savingsBalance;
    }

    public void deposit(double depositAmount, boolean isSavings){
        if(depositAmount < 0){
            System.out.println("Deposit Failed! Deposit amount must be greater than 0");
            return;
        }
        if(isSavings){
            savingsBalance += depositAmount;
        }else{
            checkingBalance += depositAmount;
        }
        totalMoneyStored += depositAmount;
    }

    public double withdraw(double withdrawAmount, boolean isSaving){
        if(withdrawAmount < 0){
            System.out.println("Withdraw Failed! Withdraw amount must be greater than 0");
            return 0;
        }
        if(isSaving){
            if(withdrawAmount > savingsBalance){
                System.out.println("Error! Insufficient funds in savings account.");
                return 0;
            }
            savingsBalance -= withdrawAmount;
        }else{
            if(withdrawAmount > checkingBalance){
                System.out.println("Error! Insufficient funds in checking account.");
                return 0;
            }
            checkingBalance -= withdrawAmount;
        }
        totalMoneyStored -= withdrawAmount;
        return withdrawAmount;
    } 

    public void displayCheckingSavings(){
        System.out.printf("Checking Account Balance : $%.2f%nSavings Account Balance : $%.2f%n", checkingBalance, savingsBalance);
    }

    private char getRandomChar(){
        Random rand = new Random();
        char[] characterList = "1234567890abcdefghijklmnopqrstuvwxyz".toCharArray();
        return characterList[rand.nextInt(characterList.length)];
    }

    private String generateAccountNumber(){
        String acctNumber = "";
        for(int i = 0; i < 8; i++){
            acctNumber += getRandomChar();
        }
        return acctNumber;
    }

    public String getAccountNumber(){
        return accountNumber;
    }

}