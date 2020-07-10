
namespace ExemploHeranca.Entities
{
    class SavingsAccount :Account //extende da classe Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            :base(number, holder, balance) //aprovitando os parâmetros de Account
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            //Este método atualiza a taxa de juros em cima do saldo
            Balance += Balance * InterestRate;
        }
        public override void Withdraw(double amount)
        {
            //Balance -= amount; //decrementa forçando esta regra ao invés da superclasse
            base.Withdraw(amount); //comando base utiliza toda a regra da superclasse
            Balance -= 2.0; //assim, é possível realizar outras regras de negócio a partir do dado recebido
        }
    }
}
