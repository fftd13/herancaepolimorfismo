using Bank.Entities;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(162, "brazilianeiro", 500.0);
            Account acc2 = new SavingAccount(132, "habadong", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}