using ExemploHeranca.Entities;
using System;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            //a atribuição é possível, pois, BusinessAccount é um Account
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            //Por mais que acc2 receba BUSINESSACCOUNT, o compilador não considera.
            //Pois o acc2 é do tipo ACCOUNT.
            //Para isso é preciso fazer um CASTING do acc2.
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            /*Embora não dê erro no compilador, esta operação está incorreta
            devido ao acc3 ser de um tipo diferente (SavingsAccount)
            O erro será exposto no momento de execução.*/
            //BusinessAccount acc5 = (BusinessAccount)acc3;

            /*Para conseguir executar esta operação, é preciso validar o tipo
             abaixo está um exemplo em como validar o tipo.
             Usando o "IS" é possível validar se a variável é do 
             tipo BusinessAcount.
             */
             if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //Usando AS é outra forma de fazer casting
                acc5.Loan(100.0);
                Console.WriteLine("Loan!");
            }

             /*O teste abaixo checa se a variável é do tipo SavingsAccount*/
             if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}
