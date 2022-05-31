using System;

namespace ConsoleApp3
{
    class Account
    {

        private double balance;
        private string name;
        public double Deposit(double depositamount)
        {
            balance = balance + depositamount;
            Console.WriteLine("debited amount is:" + balance);
            return balance;
        }
        public double getBalance(double b)
        {

            return b;
           

        }
       
        public string getName(string _name)
        {
            return _name;
        }
        class test
        {
            static void Main(String[] args)
            {
                Account a1 = new Account();
                a1.Deposit(200000);
                a1.getBalance(10000);
                a1.getName("megha");

            }
        }
    }
    
        
       
           
      
    
}
