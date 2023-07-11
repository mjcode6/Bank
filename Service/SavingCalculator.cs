using bank.Models;

namespace bank.Service
{
    public class SavingCalculator
    {
        public static double ActualAmount(SavingAccount account)
        {
            int NbIteration = 3;

            if (account.IsRateByMonth)
                NbIteration *= 12;


            double res = account.Amount;

            for(int i = 0; i < NbIteration; i++)
            {
                res = res * (1+account.Rate);
            }

            return res;
        }
    }
}
