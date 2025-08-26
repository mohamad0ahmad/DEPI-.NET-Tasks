namespace ConsoleApp1
{
    public struct Account
    {
        private int accountId;
        private string accountHolder;
        private double balance;

        public int AccountId { get => accountId; set => accountId = value; }
        public string AccountHolder { get => accountHolder; set => accountHolder = value; }
        public double Balance { get => balance; set => balance = value; }

        public Account(int id, string holder, double bal)
        {
            accountId = id;
            accountHolder = holder;
            balance = bal;
        }
    }
}
