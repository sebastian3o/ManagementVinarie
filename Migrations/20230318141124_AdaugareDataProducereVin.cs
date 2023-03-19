using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManagementVinarie.Migrations
{
    /// <inheritdoc />
    public partial class AdaugareDataProducereVin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DataProducerii",
                table: "Vinuri",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataProducerii",
                table: "Vinuri");
        }
    }
}
