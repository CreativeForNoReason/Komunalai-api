using Komunalaiapi.Data;
using Komunalaiapi.Models;

namespace Komunalaiapi
{
    public class Seed
    {
        private readonly ApplicationDbContext dataContext;
        public Seed(ApplicationDbContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void SeedDataContext()
        {
            if (!dataContext.Communals.Any())
            {
                var communal = new Communal()
                {
                    Name = "Domas",
                    Date = new DateTime(2020, 02, 20),
                    Type = "Ignitis",
                    Commune = "Electricity day",
                    Before = 20,
                    After = 40,
                    Difference = 20,
                    Price = 2.5,
                    Calculated = 50,
                    AdditionalTax = 0.0,
                    Sum = 50,
                    PaymentDate = new DateTime(2020, 02, 20),
                    Comment = "Seed Data"
                };
                dataContext.Communals.Add(communal);
                dataContext.SaveChanges();
            }            
        }
    }
}
