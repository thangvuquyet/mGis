using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mGISv3.Migrations
{
    public partial class Add_FactHousings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpFactHousing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HouseID = table.Column<long>(type: "bigint", nullable: false),
                    DateID = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    WardID = table.Column<long>(type: "bigint", nullable: false),
                    HouseTypeID = table.Column<long>(type: "bigint", nullable: false),
                    CertID = table.Column<long>(type: "bigint", nullable: false),
                    Floor = table.Column<long>(type: "bigint", nullable: false),
                    NoRoom = table.Column<long>(name: "No.Room", type: "bigint", nullable: false),
                    Area = table.Column<long>(type: "bigint", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactHousing", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpFactHousing");
        }
    }
}
