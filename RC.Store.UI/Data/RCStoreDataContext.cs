using RC.Store.UI.Models;
using System.Data.Entity;

namespace RC.Store.UI.Data
{
    public class RCStoreDataContext : DbContext
    {
        

        public DbSet<Produto> Produtos { get; set; }

        public RCStoreDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RCStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {                                 //"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Store;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                                          //"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"


            Database.SetInitializer(new DbInitializer());
        }
    }
}