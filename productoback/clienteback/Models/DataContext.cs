

namespace clienteback.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<clienteback.Models.Client> Clients { get; set; }
    }
}