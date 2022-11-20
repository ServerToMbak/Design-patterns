using Design_patterns;

public class Program
{
    static void Main(string[] args)
    {
        IAccountFactory accountFactory = new AccountFactory();

        var savingAccount = accountFactory.GetAccountType("SAVINGS");
        Console.WriteLine("Saving account balance: " + savingAccount.Balance);

        var currentAccount = accountFactory.GetAccountType("CURRENT");
        Console.WriteLine("Current account balance: " + currentAccount.Balance);
        
    }
}