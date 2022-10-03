using Bank.Entities;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(153, "Broly", 0.0);
            BusinessAccount bacc = new BusinessAccount(154, "Goku", 0.0, 500.0);

            // UPCASTING

            Account acc2 = bacc;
            Account acc3 = new BusinessAccount(154, "Vegeta pereca", 0.0, 500.0);
            Account acc4 = new SavingAccount(332, "Kelvin", 0.0, 0.01);

            // DOWNCASTING
            
            BusinessAccount acc5 = (BusinessAccount)acc2;
            acc5.Loan(100.0);
            //acc3.Loan(100.0);
            //BusinessAccount acc6 = (BusinessAccount)acc4;

            if (acc4 is BusinessAccount)
            {
                //BusinessAccount acc6 = (BusinessAccount)acc4;
                BusinessAccount acc6 = acc4 as BusinessAccount;
                acc6.Loan(200.0);
                Console.WriteLine("Loan");
            }
            else if(acc4 is SavingAccount)
            {
                SavingAccount acc6 = (SavingAccount)acc4;
                acc6.UpdateBalance();
                Console.WriteLine("Update");
            }

        }
    }
}