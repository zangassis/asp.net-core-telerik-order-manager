using OrderManager.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource = orderDB; Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seedData = Enumerable.Range(1, 30).Select(i => new OrderViewModel
            {
                OrderID = i,
                Freight = i * 10,
                OrderDate = new DateTime(2022, 04, 25).AddDays(i % 7),
                ShipName = "ShipNameExample" + i,
                ShipCity = "ShipCityExample" + i
            }).ToList();

            modelBuilder.Entity<OrderViewModel>().HasData(
                seedData[0], seedData[1], seedData[2], seedData[3], seedData[4], seedData[5],
                seedData[6], seedData[7], seedData[8], seedData[9], seedData[10], seedData[11],
                seedData[12], seedData[13], seedData[14], seedData[15], seedData[16], seedData[17],
                seedData[18], seedData[19], seedData[20], seedData[21], seedData[22], seedData[23],
                seedData[24], seedData[25], seedData[26], seedData[27], seedData[28], seedData[29]);
        }

        public DbSet<OrderViewModel> Orders { get; set; }
    }
}