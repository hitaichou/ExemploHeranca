
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
    }
}
