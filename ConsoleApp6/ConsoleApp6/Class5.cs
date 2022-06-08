using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
   
 class Source
    {
        static void Main(string[] args)
        {
        }
    }
    public class InsufficientFuncException : System.Exception
    {
        public string TransactionAmount { set; get; }
        public int AccountBalance { get; set; }
        public int AccountName { get; set; }
        public InsufficientFuncException(string Tamount, int AcBal, int AcNo)
        {
            this.TransactionAmount = Tamount;
            this.AccountBalance = AcBal;
            this.AccountName = AcNo;
        }
    }
    class Account
    {
        public string Name { private set; get; }
        public int balance { private set; get; }
        public Account(string name, int balance)
        {
            this.Name = name;
            this.balance = balance;
        }
        public int Debit(int amount)
        {
            try
            {
                if (this.balance < amount)
                    throw new InsufficientFuncException(Name, balance, amount);
                else
                {
                    this.balance -= amount;
                }
            }
            catch (Exception) { }
            return this.balance;
        }
        public int Credit(int amount)
        {
            this.balance += amount;
            return (this.balance);
        }
    }
}
