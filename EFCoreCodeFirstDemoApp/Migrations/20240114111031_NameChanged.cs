using EFCoreCodeFirstDemoApp.Entities;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreCodeFirstDemoApp.Migrations
{
    /// <inheritdoc />
    public partial class NameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("High", "Students", "Heigh");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("Heigh", "Students", "High");

        }
    }
}
