using ExemploHeranca.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);*/

            //crio a lista do tipo Account
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            //somando todos os saldos em uma única variável
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

            //sacando 10 de cada conta.
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            //mostro cada saldo individual
            foreach(Account acc in list)
            {
                Console.WriteLine("Balance updated: "
                                 + acc.Number
                                 + ": "
                                 + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            sum = 0.0;
            //Mostro novamente o novo saldo
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("New Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
