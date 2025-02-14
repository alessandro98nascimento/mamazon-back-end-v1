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
        public DbSet<Email> Emails { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<ResidencesUser> ResidencesUsers { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        UserId = 1,
                        UserName = "Alessandro Santos do Nascimento",
                        ActiveUser = 1,
                        EmailId = 1,
                        PasswordId = 1,
                    },
                    new User
                    {
                        UserId = 2,
                        UserName = "Guilherme Ferreira de Morais Pinho",
                        ActiveUser = 1,
                        EmailId = 2,
                        PasswordId = 2,
                    },
                    new User
                    {
                        UserId = 3,
                        UserName = "Vinicius Souza Duarte",
                        ActiveUser = 0,
                        EmailId = 3,
                        PasswordId = 3,
                    }
                );

            modelBuilder.Entity<Password>()
                .HasData(
                    new Password
                    {
                        PasswordId = 1,
                        UserPassword = "123456"
                    },
                    new Password
                    {
                        PasswordId = 2,
                        UserPassword = "456789"
                    },
                    new Password
                    {
                        PasswordId = 3,
                        UserPassword = "987654"
                    }
                );

            modelBuilder.Entity<Email>()
                .HasData(
                    new Email
                    {
                         EmailId = 1,
                         UserEmail = "alessandro-s-nascimento@hotmail.com"
                    },
                    new Email
                    {
                        EmailId = 2,
                        UserEmail = "guilherme-m-pinho@hotmail.com"
                    },
                    new Email
                    {
                        EmailId = 3,
                        UserEmail = "vinicius-s-duarte@hotmail.com"
                    }
                );

            modelBuilder.Entity<Residence>()
                .HasData(
                    new Residence
                    {
                        ResidenceId = 1,
                        Adress = "Rua da escuridão",
                        NumberHouse = 69,
                        Cep = 11760000,
                        Neighborhood = "Paraguai 1",
                        Complement = "Casa",
                        CityId = 1,
                    },
                    new Residence
                    {
                        ResidenceId = 2,
                        Adress = "Rua do suco",
                        NumberHouse = 8000,
                        Cep = 11760000,
                        Neighborhood = "Pop",
                        Complement = "Casa",
                        CityId = 1,
                    },
                    new Residence
                    {
                        ResidenceId = 3,
                        Adress = "Sua da fé",
                        NumberHouse = 24,
                        Cep = 11760000,
                        Neighborhood = "Paraguai 1",
                        Complement = "Casa",
                        CityId = 1,
                    }
                );

            modelBuilder.Entity<ResidencesUser>()
                .HasData(
                    new ResidencesUser
                    {
                        ResidencesUserId = 1,
                        UserId = 1,
                        ResidenceId = 1,
                    },
                    new ResidencesUser
                    {
                        ResidencesUserId = 2,
                        UserId = 2,
                        ResidenceId = 2,
                    },
                    new ResidencesUser
                    {
                        ResidencesUserId = 3,
                        UserId = 3,
                        ResidenceId = 3,
                    }
                );

            modelBuilder.Entity<City>()
                .HasData(
                    new City
                    {
                        CityId = 1,
                        CityName = "Itariri",
                        StateId = 1,
                    }
                );

            modelBuilder.Entity<State>()
                .HasData(
                    new State
                    {
                        StateId = 1,
                        StateName = "SP"
                    }
                );
        }
    }
}
