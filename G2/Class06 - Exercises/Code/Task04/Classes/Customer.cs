

namespace Task04.Classes
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        private int _pin { get; set; }
        private double _accountBalance { get; set; }

        public Customer(string firstName, string lastName, string cardNumber, int pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            _pin = pin;
            _accountBalance = balance;
        }
        //Because _accountBalance is private, we need method
        public double GetAccountBalance()
        {
            return _accountBalance;
        }

        //Because _pin is private, we need method for checks
        public bool CheckPin(int pin)
        {
            return _pin == pin;
        }

        //Because _accountBalance is private, we need method
        public void MakeDeposit(int amount)
        {
            _accountBalance += amount;
        }

        //Because _accountBalance is private, we need method
        public bool MakeWithdrawal(int amount)
        {
            if (amount > _accountBalance)
                return false;
            _accountBalance -= amount;
            return true;
        }
    }
}
