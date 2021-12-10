using Bank.Exceptions;

namespace Bank.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double initialBalance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = initialBalance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void WithDraw(double ammount)
        {
            if(ammount > Balance)
            {
                throw new BankException("Not enough balance");
            }
            if (ammount > WithDrawLimit)
            {
                throw new BankException("The ammount exceeds withdraw limit");
            }
            Balance -= ammount;
        }

    }
}
