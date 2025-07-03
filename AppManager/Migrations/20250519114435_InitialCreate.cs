using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppId = table.Column<string>(type: "TEXT", nullable: false),
                    AppName = table.Column<string>(type: "TEXT", nullable: false),
                    PlanAppId = table.Column<string>(type: "TEXT", nullable: false),
                    AppTech = table.Column<string>(type: "TEXT", nullable: false),
                    Version = table.Column<string>(type: "TEXT", nullable: false),
                    TechOutOfSupport = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRecords", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppRecords_AppId_AppTech",
                table: "AppRecords",
                columns: new[] { "AppId", "AppTech" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRecords");
        }
    }
}
