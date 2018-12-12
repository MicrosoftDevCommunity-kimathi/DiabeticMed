using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DiabeticmedApi.Migrations
{
    public partial class CloudDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    BMi = table.Column<float>(nullable: false),
                    Diabetic = table.Column<float>(nullable: false),
                    DiabeticPadiac = table.Column<float>(nullable: false),
                    DiasotolicBloodPressure = table.Column<float>(nullable: false),
                    Isdiabetic = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PlasmaGlucose = table.Column<float>(nullable: false),
                    Pregnanicies = table.Column<int>(nullable: false),
                    Seruminium = table.Column<float>(nullable: false),
                    TricepThickness = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
