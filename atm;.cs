using System;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum ,int pin , string firstName , string lastName , double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin ;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance ;

    }


    public string getNum()
    {
        return cardNum;
    }

    public int getpin()
    {
        return pin;
    }

    public string getfirstName()
    {
        return firstName;

    }

    public string getlastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("please choose from on of the following...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. withdraw");
            Console.WriteLine("3. show balance");
            Console.WriteLine("4. exist");


        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit??");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance + deposit);
            Console.WriteLine("thank you for your $$. your new Balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("how much $$ would you like to withdraw:");
            double withdrawal = Double.Parse(Console.ReadLine());

            if (currentUser.getBalance() > withdrawal){
                Console.WriteLine("insufficient balance:(");
            }
            else{
                currentUser.setBalance(current.User.getBalance()-withdrawal);
                Console.WriteLine("you are good to go! thankyou:");
            }
        }
        void balance (cardHolder currentUser)
        {
            Console.WriteLine("current balance :" + currentUser.getBalance());
        }

        List <cardHolder> cardHolder = new List <cardHolder>();

        cardHolders.add(new cardHolders("123454343456891",1231,"donald","trump",900.55));
         cardHolders.add(new cardHolders("123454343456892",1232,"mbs","saudi",500.55));
          cardHolders.add(new cardHolders("123454343456893",1233,"john","cena",700.55));
           cardHolders.add(new cardHolders("123454343456894",1234,"kevin","heart",550.35));
            cardHolders.add(new cardHolders("123454343456895",1235,"joe","biden",439.55));

        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Please insert your debit card: "); 
        String DebitCardNum = "";
        cardHolder currentUser;

        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == DebitCardNum);
                if (currentUser != null){ break; } 
                else {Console.WriteLine("card not recorganazied please try again");}
                
            }
            catch { Console.WriteLine("card not recorganized please try again");}

        }    

        Console.WriteLine("please enter your pin: ");
         int userPin = 0;

            while(true){
            try
            {
                userPin = int.Parse(Console.ReadLine());                
                if (currentUser.getPin() == userPin){ break; } 
                else {Console.WriteLine("Incorrect pin please try again"); }
            }    
            catch { Console.WriteLine("incorrect oin please try again"); }
            }

            Console.WriteLine("welcome" + currentUser.getFirstName() + ":)");
            int option = 0;
            do
            {
                printOptions();
                try{
                    option = intParse(Console.ReadLine());
                }
                catch{}
                    if(option == 1){deposit(currentUser);}
                    else if (option == 2){withdraw(currentUser);}
                    else if (option == 2){withdraw(currentUser);}
                    else if(option == 4) {break ;}   
                    else {option = 0;}            
                
            } 
            while (option != 4);
            Console.WriteLine("Thank you have a nice day :)");


       }
};