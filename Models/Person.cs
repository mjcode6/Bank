namespace bank.Models
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public List<SavingAccount> Savingaccounts { get; }
        public List<SavingAccount> SavingAccounts { get; set; }
       

        public Person()
        {

        }
        public Person(string name, List<SavingAccount> savingaccounts)
        {
            Name = name;
            Savingaccounts = savingaccounts;
        } 
    }
}
