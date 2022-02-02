using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JurisTempus.Data.Migrations
{
    public partial class ShemaChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeBills",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkDate",
                value: new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeBills",
                keyColumn: "Id",
                keyValue: 1,
                column: "WorkDate",
                value: new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
