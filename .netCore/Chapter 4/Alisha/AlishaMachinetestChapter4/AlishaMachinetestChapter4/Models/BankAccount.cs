using AlishaMachinetestChapter4.Exceptions;
using AlishaMachinetestChapter4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlishaMachinetestChapter4.Models
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
        public AccountType Type{ get; set; }
        public BankAccount(int accountNumber,string name,decimal balance,AccountType type)
        {
            AccountNumber = accountNumber;
            AccountHolderName = name;
            Balance = balance;
            Type = type;
        }
        public void Deposit(decimal amunt)
        {
            Balance = amunt;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientBalanceException("Insufficient Balance");
            Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account number:{AccountNumber},Balance :{Balance}";
        }
    }
}
