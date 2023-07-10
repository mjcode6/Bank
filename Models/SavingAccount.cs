namespace bank.Models
{
    public class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public double Amount { get; set; }    
        public double Rate { get; set; }
        public bool IsRateByMonth { get; set; } 

        public SavingAccount(double amount, double rate, bool isRateByMonth) 
        {
            SavingAccountId = Guid.NewGuid();
            this.Amount = amount;
            this.Rate = rate;
            IsRateByMonth = isRateByMonth;


        }
    }
}
