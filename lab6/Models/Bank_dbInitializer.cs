using System.Data.Entity;

namespace lab6.Models
{
    public class Bank_dbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            db.Banks.Add(new Bank { bank_id = 1, bank_name = "Privat24", bank_amount_of_clients = 45234130 });
            db.Banks.Add(new Bank { bank_id = 2, bank_name = "Monobank", bank_amount_of_clients = 2441244 });
            db.Banks.Add(new Bank { bank_id = 3, bank_name = "Ideabank", bank_amount_of_clients = 99449 });
           
            base.Seed(db);
        }
    }
}