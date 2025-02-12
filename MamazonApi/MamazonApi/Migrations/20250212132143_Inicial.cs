using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MamazonApi.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NumberHouse = table.Column<int>(type: "int", nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false),
                    Complement = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActiveUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ActiveUser", "Adress", "Cep", "City", "Complement", "Email", "Neighborhood", "NumberHouse", "Password", "State", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "Rua do Xesque", 11760000, "Itariri", "Casa", "alessandro-s-nascimento@hotmail.com", "Paraguai 1", 69, "123456", "SP", "Alessandro Santos do Nascimento" },
                    { 2, 1, "Rua do Suco", 11760000, "Itariri", "Casa", "guilherme-m-pinho@hotmail.com", "Pop", 8000, "456789", "SP", "Guilherme Ferreira de Morais Pinho" },
                    { 3, 0, "Rua do Fé", 11760000, "Itariri", "Casa", "vinicius-s-duarte@hotmail.com", "Paraguai 2", 24, "987654", "SP", "Vinicius Souza Duarte" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
