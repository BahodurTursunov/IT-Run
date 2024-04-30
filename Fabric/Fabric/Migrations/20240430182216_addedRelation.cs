using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fabric.Migrations
{
    /// <inheritdoc />
    public partial class addedRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductStore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Worker",
                table: "Worker");

            migrationBuilder.RenameTable(
                name: "Worker",
                newName: "Workers");

            migrationBuilder.RenameColumn(
                name: "WorkersInDepartment",
                table: "Departments",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Customers",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Workers",
                newName: "Responsibility");

            migrationBuilder.RenameColumn(
                name: "Respontibility",
                table: "Workers",
                newName: "Position");

            migrationBuilder.AddColumn<Guid>(
                name: "WorkerId1",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId1",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_WorkerId1",
                table: "Departments",
                column: "WorkerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductId1",
                table: "Categories",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_ProductId1",
                table: "Categories",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Workers_WorkerId1",
                table: "Departments",
                column: "WorkerId1",
                principalTable: "Workers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_ProductId1",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Workers_WorkerId1",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Departments_WorkerId1",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductId1",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkerId1",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Worker");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Departments",
                newName: "WorkersInDepartment");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Customers",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Responsibility",
                table: "Worker",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Worker",
                newName: "Respontibility");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker",
                table: "Worker",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProductStore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStore", x => x.Id);
                });
        }
    }
}
