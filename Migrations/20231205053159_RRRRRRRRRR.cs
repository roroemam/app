using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstTask.Migrations
{
    /// <inheritdoc />
    public partial class RRRRRRRRRR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "Donors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "paymentDate",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 5, 7, 31, 59, 467, DateTimeKind.Local).AddTicks(5104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 5, 7, 28, 29, 352, DateTimeKind.Local).AddTicks(2167));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "paymentDate",
                table: "Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 5, 7, 28, 29, 352, DateTimeKind.Local).AddTicks(2167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 5, 7, 31, 59, 467, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.AddColumn<byte[]>(
                name: "image",
                table: "Donors",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
