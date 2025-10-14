using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlishaMachinetestChapter4.Exceptions;
using AlishaMachinetestChapter4.Models;

namespace AlishaMachinetestChapter4.Managers
{
    public class Bank
    {
       public List<BankAccount> accounts = new List<BankAccount>();
        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
        }
        public void RemoveAccount(int accountNumber )
        {
            BankAccount acc=accounts.Find(a=>a.AccountNumber==accountNumber);
            if(acc==null)
                throw new AccountDoesNotExistException("Account not found");
            accounts.Remove(acc);
        }
        public BankAccount GetAccount(int accountNumber)
        {
            BankAccount acc=accounts.Find(a=>a.AccountNumber == accountNumber);
            if(acc==null)
                throw new AccountDoesNotExistException("Account not found");
            return(acc);

        }
      


    }
}
