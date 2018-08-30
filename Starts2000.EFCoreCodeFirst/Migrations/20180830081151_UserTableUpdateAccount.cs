﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Starts2000.EFCoreCodeFirst.Migrations
{
    public partial class UserTableUpdateAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_User_Aaccount",
                table: "User",
                column: "Aaccount",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Aaccount",
                table: "User");
        }
    }
}
