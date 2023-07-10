namespace bank.Models
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public List<SavingAccount> SavingAccounts { get; set; }
        public List<SavingAccount> Savingaccounts { get; }

        public Person()
        {

        }
        public Person(string name, List<SavingAccount> savingaccounts)
        {
            Savingaccounts = savingaccounts;
        } 
    }
}
