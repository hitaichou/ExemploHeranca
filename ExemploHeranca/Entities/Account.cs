using System;

namespace ExemploHeranca.Entities
{
    //abstract --> determino que esta classe não poderá ser usada 
    //para inserir dados
    abstract class Account
    {
        /*
         
            Usando o PRIVATE no SET, nós estamos encapsulando a variável,
            o dado fica somente leitura pelas outras classes, ou seja,
            não é possível que sejam alterados por outra classe, somente acessados
            -------------------
            Usando o PROTECTED, a variável pode ser alterada pela subclasse.

        */
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

       
        //usando o virtual, permite que o Saldo pode ser
        //sobrescrito nas subclasses.
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
