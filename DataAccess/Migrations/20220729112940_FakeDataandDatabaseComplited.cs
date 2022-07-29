using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FakeDataandDatabaseComplited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "DeliveryId", "CargoMan", "DeliveryDate", "Status", "VehicleNumber" },
                values: new object[,]
                {
                    { 1, "Ahmet", new DateTime(2022, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), 0, "02A223" },
                    { 2, "Mehmet", new DateTime(2022, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), 0, "20B2020" },
                    { 3, "Ali", new DateTime(2021, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), 2, "30C234" },
                    { 4, "Esra", new DateTime(2021, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), 2, "15v3030" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "GetDelivery" },
                    { 2, "deliveryenter" },
                    { 3, "deliveryhandover" },
                    { 4, "deliverytake" },
                    { 5, "getorder" },
                    { 6, "addproduct" },
                    { 7, "addorder" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 2, 30 },
                    { 2, 1, 2, 40 },
                    { 3, 2, 2, 20 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "ContactNumber", "EndPoint", "OrderDate", "StartPoint" },
                values: new object[,]
                {
                    { 1, "", "Zonguldak", new DateTime(2021, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), "Bursa" },
                    { 2, "", "Samsun", new DateTime(2021, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), "İstanbul" },
                    { 3, "", "İstanbul", new DateTime(2021, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), "İzmir" },
                    { 4, "", "Antalya", new DateTime(2021, 7, 29, 14, 40, 52, 0, DateTimeKind.Unspecified), "Muğla" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName" },
                values: new object[,]
                {
                    { 1, "Tablet" },
                    { 2, "Laptop" },
                    { 3, "Telefon" },
                    { 4, "Hoparlör" }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "OperationClaimId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 5, 1 },
                    { 5, 1, 2 },
                    { 6, 4, 1 },
                    { 7, 6, 1 },
                    { 8, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { 1, "acompany@gmail.com", "123" },
                    { 2, "bcompany@gmail.com", "345" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "DeliveryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
