using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns
{
    public abstract class AccountType
    {   
        public string Balance { get; set; }

    }
    public class SavingAccount:AccountType
    {
        public SavingAccount()
        {
            Balance = "10000 Rs";
        }
    }

    public class CurrentAccount : AccountType
    {
        public CurrentAccount()
        {
            Balance="20000 Rs";
        }
    }

    public interface IAccountFactory
    {
        AccountType GetAccountType(string accountName);
    }


    public class AccountFactory : IAccountFactory
    {
        public AccountType GetAccountType(string accountName)
        {
            if (accountName.Equals("SAVINGS", StringComparison.OrdinalIgnoreCase))
            {
                return new SavingAccount();
            }
            else if (accountName.Equals("CURRENT", StringComparison.OrdinalIgnoreCase))
            {
                return new CurrentAccount();
            }
            else
            {
                throw new ArgumentException("Invalid account name");
            }
        }

       

    }
}
