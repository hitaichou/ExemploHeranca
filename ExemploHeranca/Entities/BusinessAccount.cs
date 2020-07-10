
namespace ExemploHeranca.Entities
{
    //método para fazer a classe herdar.
    //: NomeDaClasse faz com que a classe que está sendo criada
    //herde as características da superclasse
    class BusinessAccount : Account 
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }
       //A forma abaixo demonstra reaproveitamento de código.
       //Passando no construtor todos os parâmetros de entrada da superclasse e da classe atual
       //é possível usar o comando ": base" e passar os parâmetros da superclasse sem precisar 
       //colocar ela para receber abaixo.
       public BusinessAccount(int number, string holder, double balance, double loalLimit) :base(number, holder, balance)
       {
            LoanLimit = loalLimit;
       }
    
       public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
