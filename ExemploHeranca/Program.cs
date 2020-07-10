using ExemploHeranca.Entities;
using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            //não é possível atribuir um valor ao saldo, pois a variável está PROTECTED (protegida)
            //account.Balance = 200.0;
        }
    }
}
