namespace Movil.Backend.Models
{
    using Domain.Models;
    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<Movil.Common.Models.Product> Products { get; set; }
    }
}