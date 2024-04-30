using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FANCY_CLOTHES_MANAGEMENT.Migrations
{
    /// <inheritdoc />
    public partial class SM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12d44612-eeca-4f8d-95db-50d0e8a9f7cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab399fd-c223-4a0a-9fbb-d93b388cae65");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "acf1ece8-3670-44fc-82d2-f2f7d9c9e0cf", null, "Merchant", "Merchant" },
                    { "ff75ca90-bb96-4acc-9f0a-a4149ceb536d", null, "Customer", "Customer" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "AspNetRoles",
               keyColumn: "Id",
               keyValue: "acf1ece8-3670-44fc-82d2-f2f7d9c9e0cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff75ca90-bb96-4acc-9f0a-a4149ceb536d");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12d44612-eeca-4f8d-95db-50d0e8a9f7cf", null, "Customer", "Customer" },
                    { "fab399fd-c223-4a0a-9fbb-d93b388cae65", null, "Merchant", "Merchant" }
                });
        }
    }
}
