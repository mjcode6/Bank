using bank.Models;

namespace bank
{
    public class Program
    {
       

        public static void Main(string[] args)
        {
            InitDb();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
        public static void InitDb()
        {
            using (var context = new SavingContext())
            { 


                  context.Database.EnsureDeleted();
                  context.Database.EnsureCreated();


               


            //initialiser les donn�es

                    List<SavingAccount> johnAccounts = new List<SavingAccount>
                    {
                
                
                              new SavingAccount(2000000, 0.05,true),
                              new SavingAccount(250000, 0.015,false),
                              new SavingAccount(10000000, 0.02,false),

                    };


               Person richard = new Person("Mr Richard", johnAccounts);
 
               context.Add(richard);


                context.SaveChanges();
            }

        }
    }
}