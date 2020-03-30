namespace BankV10
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
            _balance = _balance + amount;
            }
            else
            {
            System.Console.WriteLine("Du kan ikke indsætte et negativt beløb");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount >= 0 && _balance >= amount)
            {
            _balance = _balance - amount;
            }
            else
            {
            System.Console.WriteLine("Du kan ikke hæve et negativt beløb, eller flere penge end du har på din konto");
            }
            
            
        } 
        #endregion
    }
}