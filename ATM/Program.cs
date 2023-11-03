using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;
    private int newPin;
    private string newFirstName;
    private string newLastName;
    private double newBalance;
    private string getBalance;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public cardHolder(string cardNum,
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
                      int pin,
                      string firstName,
                      string lastName,
                      double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public cardHolder()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
    }

    public String getCardNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getfirstName()
    {
        return firstName;
    }
    public String getlastName()
    {
        return lastName;
    }
    public double getbalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int pin)
    {
        pin = newPin;
    }

    public void setFirstName(String firstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String lastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double balance)
    {
        balance = newBalance;
    }

    public static void main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = double.Parse(s: Console.ReadLine());
            currentUser.balance = deposit;
            Console.WriteLine("Thank you for you $$. Your new balance is: " + currentUser.getBalance);
        }

        void Withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw? ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //check if user has enough money
            if (currentUser.getbalance() > withdrawal)
            {
                Console.WriteLine("Insufficient balance :(");
            }
            else
            {

                currentUser.setbalance(currentUser.getbalance() - withdrawal);
                Console.WriteLine("You're good to go! Thank You :)");
            }
            }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.GetBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4532772818527395", 1234, "John", "Griffin", 150.31 ));
        cardHolders.Add(new cardHolder("4532772822127395", 4788, "Kate", "Anderson", 800.81));
        cardHolders.Add(new cardHolder("8832772818527395", 2227, "Peter", "Smith", 196.22));
        cardHolders.Add(new cardHolder("3554792818527395", 5579, "Stacy", "Louis", 589.41));
        cardHolders.Add(new cardHolder("7822472818527395", 4793, "Stewy", "Brown", 430.96));

        //Prompt User
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check against our DB(database)
                currentUser = cardHolders.FirstOrDefault( a => a.cardNum == debitCardNum );
                if(currentUser != null ) { break; }
                else { Console.WriteLine("Card not recognized. Please try again"); }

            }
            catch { Console.WriteLine("Card not recognized. Please try again"); }
            
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                //check against our DB(database)
                if (currentUser.getPin() == userPin)  { break; }
                else { Console.WriteLine("Incorrect pin. Please try again."); }

            }
            catch { Console.WriteLine("Incorrect pin. Please try again."); }
        }

        Console.WriteLine("Welcome " + currentUser.getfirstName() + " :)");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { Withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day :)");

    }

    private string GetBalance()
    {
        throw new NotImplementedException();
    }

    private void setbalance(double v)
    {
        throw new NotImplementedException();
    }
}

    
