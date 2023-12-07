namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount balance = new BankAccount("12345678", 0);
            balance.Deposite(1000);
            balance.Withdraw(500);
            balance.Output();

        }
    }
}