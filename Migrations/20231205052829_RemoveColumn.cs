using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstTask.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "paymentDate",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 5, 7, 28, 29, 352, DateTimeKind.Local).AddTicks(2167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 29, 16, 3, 53, 502, DateTimeKind.Local).AddTicks(5074));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "paymentDate",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 29, 16, 3, 53, 502, DateTimeKind.Local).AddTicks(5074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 5, 7, 28, 29, 352, DateTimeKind.Local).AddTicks(2167));
        }
    }
}
