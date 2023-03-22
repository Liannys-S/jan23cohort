public class TestBankAccount {
    public static void main(String[] args) {
        
        BankAccount customer1 = new BankAccount(100,500);
        BankAccount customer2 = new BankAccount();

        customer1.deposit(50,false); // deposit 50 into checkings
        customer1.withdraw(100, true); //withdraw 100 from savings
        customer1.displayCheckingSavings();
        
        customer1.withdraw(600, true); //withdraw 600 from savings should result in error 
        customer1.displayCheckingSavings();

        customer2.deposit(-100, false); //deposit neg number to checking acc (error)
        customer2.displayCheckingSavings();

        System.out.println(BankAccount.accountsCreated);
        System.out.println(BankAccount.totalMoneyStored);

        
        System.out.println(customer1.getAccountNumber());
        System.out.println(customer2.getAccountNumber());
    }
}
