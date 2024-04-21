namespace BankAcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcountPerson acc = new BankAcountPerson();
            acc.Id = 1;
            acc.Deposit(15);
            acc.Withdraw(5);
            acc.Print();
        }
    }
}
