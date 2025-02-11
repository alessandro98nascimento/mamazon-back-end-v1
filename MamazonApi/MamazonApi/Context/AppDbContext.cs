using MamazonApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MamazonApi.Context
{
    public class AppDbContext : DbContext
    {
        private string? StringConnection = "Server = localhost\\SQLEXPRESS01; Database=master;Trusted_Connection=True; TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(StringConnection);

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    UserName = "Alessandro Santos do Nascimento",
                    Email = "alessandro-s-nascimento@hotmail.com",
                    Password = "123456",
                    Adress = "Rua do Xesque",
                    NumberHouse = 69,
                    Cep = 11760000,
                    Complement = "Casa",
                    Neighborhood = "Paraguai 1",
                    City = "Itariri",
                    State = "SP",
                    ActiveUser = 1,
                },
                new User
                {
                    UserId = 2,
                    UserName = "Guilherme Ferreira de Morais Pinho",
                    Email = "guilherme-m-pinho@hotmail.com",
                    Password = "456789",
                    Adress = "Rua do Suco",
                    NumberHouse = 8000,
                    Cep = 11760000,
                    Complement = "Casa",
                    Neighborhood = "Pop",
                    City = "Itariri",
                    State = "SP",
                    ActiveUser = 1,
                },
                new User
                {
                    UserId = 3,
                    UserName = "Vinicius Souza Duarte",
                    Email = "vinicius-s-duarte@hotmail.com",
                    Password = "987654",
                    Adress = "Rua do Fé",
                    NumberHouse = 24,
                    Cep = 11760000,
                    Complement = "Casa",
                    Neighborhood = "Paraguai 2",
                    City = "Itariri",
                    State = "SP",
                    ActiveUser = 0,
                }
                );

        }
    }
}
