using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApteConsultancy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Lelll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Architects",
                columns: table => new
                {
                    ArchitectId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Architects", x => x.ArchitectId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorEmployeeCode = table.Column<int>(type: "int", nullable: false),
                    DirectorMobile = table.Column<int>(type: "int", nullable: false),
                    LandLine = table.Column<int>(type: "int", nullable: false),
                    DirectorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ArchitectId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AssociateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProjectCode = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientWoNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjecLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalFees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FeesReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FeesBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Expenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProfitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Architects_ArchitectId",
                        column: x => x.ArchitectId,
                        principalTable: "Architects",
                        principalColumn: "ArchitectId");
                    table.ForeignKey(
                        name: "FK_Projects_Associate_AssociateId",
                        column: x => x.AssociateId,
                        principalTable: "Associate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_Projects_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Projects_EMployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMployee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drawings",
                columns: table => new
                {
                    DrawingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ArchitectId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DrawingNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawings", x => x.DrawingId);
                    table.ForeignKey(
                        name: "FK_Drawings_Architects_ArchitectId",
                        column: x => x.ArchitectId,
                        principalTable: "Architects",
                        principalColumn: "ArchitectId");
                    table.ForeignKey(
                        name: "FK_Drawings_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_Drawings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Drawings_EMployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMployee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Drawings_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTimeSheets",
                columns: table => new
                {
                    EmployeeTimeSheetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WorkDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RatePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTimeSheets", x => x.EmployeeTimeSheetId);
                    table.ForeignKey(
                        name: "FK_EmployeeTimeSheets_EMployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMployee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeTimeSheets_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "OwnCarLocalAndOutStations",
                columns: table => new
                {
                    OwnCarLocalAndOutStationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PetrolRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarAvgKMPL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DistanceTravelled = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostOfTravel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PublicTransport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DrawingPrints = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Courier = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Toll = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnCarLocalAndOutStations", x => x.OwnCarLocalAndOutStationId);
                    table.ForeignKey(
                        name: "FK_OwnCarLocalAndOutStations_EMployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMployee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OwnCarLocalAndOutStations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "DrawingRevisions",
                columns: table => new
                {
                    DrawingRevisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrawingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawingRevisions", x => x.DrawingRevisionId);
                    table.ForeignKey(
                        name: "FK_DrawingRevisions_Drawings_DrawingId",
                        column: x => x.DrawingId,
                        principalTable: "Drawings",
                        principalColumn: "DrawingId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrawingRevisions_DrawingId",
                table: "DrawingRevisions",
                column: "DrawingId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_ArchitectId",
                table: "Drawings",
                column: "ArchitectId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_ClientId",
                table: "Drawings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_CompanyId",
                table: "Drawings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_EmployeeId",
                table: "Drawings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_ProjectId",
                table: "Drawings",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeSheets_EmployeeId",
                table: "EmployeeTimeSheets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeSheets_ProjectId",
                table: "EmployeeTimeSheets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnCarLocalAndOutStations_EmployeeId",
                table: "OwnCarLocalAndOutStations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnCarLocalAndOutStations_ProjectId",
                table: "OwnCarLocalAndOutStations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ArchitectId",
                table: "Projects",
                column: "ArchitectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AssociateId",
                table: "Projects",
                column: "AssociateId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CompanyId",
                table: "Projects",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_EmployeeId",
                table: "Projects",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrawingRevisions");

            migrationBuilder.DropTable(
                name: "EmployeeTimeSheets");

            migrationBuilder.DropTable(
                name: "OwnCarLocalAndOutStations");

            migrationBuilder.DropTable(
                name: "Drawings");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Architects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
