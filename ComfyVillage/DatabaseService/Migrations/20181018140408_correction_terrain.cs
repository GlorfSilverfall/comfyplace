﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseService.Migrations
{
    public partial class correction_terrain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SIZE",
                table: "Terrain",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SIZE",
                table: "Terrain");
        }
    }
}
