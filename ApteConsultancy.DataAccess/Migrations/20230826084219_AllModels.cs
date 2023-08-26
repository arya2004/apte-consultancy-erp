using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApteConsultancy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AllModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Associate_Fees",
                columns: table => new
                {
                    Associate_FeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssociateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Project_Fee = table.Column<double>(type: "float", nullable: false),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Transaction_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TDSAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associate_Fees", x => x.Associate_FeeId);
                    table.ForeignKey(
                        name: "FK_Associate_Fees_Associate_AssociateId",
                        column: x => x.AssociateId,
                        principalTable: "Associate",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AssociateWorkerOrders",
                columns: table => new
                {
                    AssociateWorkerOrdersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    AssociateUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkOrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WoAmmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WoDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WoStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociateWorkerOrders", x => x.AssociateWorkerOrdersId);
                    table.ForeignKey(
                        name: "FK_AssociateWorkerOrders_Associate_AssociateUserId",
                        column: x => x.AssociateUserId,
                        principalTable: "Associate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssociateWorkerOrders_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "Employee_Attendances",
                columns: table => new
                {
                    Employee_AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Attendance_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Attendances", x => x.Employee_AttendanceId);
                    table.ForeignKey(
                        name: "FK_Employee_Attendances_EMployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EMployee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GSTInvoices",
                columns: table => new
                {
                    GSTInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GSTInvoices", x => x.GSTInvoiceId);
                    table.ForeignKey(
                        name: "FK_GSTInvoices_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProformaInvoices",
                columns: table => new
                {
                    ProformaInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    GST_Invoice_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GST_Invoice_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GST_Invoice_Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProformaInvoices", x => x.ProformaInvoiceId);
                    table.ForeignKey(
                        name: "FK_ProformaInvoices_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectFees",
                columns: table => new
                {
                    ProjectFeesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    TRXDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TRXno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TDSAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFees", x => x.ProjectFeesId);
                    table.ForeignKey(
                        name: "FK_ProjectFees_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Associate_Fees_AssociateId",
                table: "Associate_Fees",
                column: "AssociateId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociateWorkerOrders_AssociateUserId",
                table: "AssociateWorkerOrders",
                column: "AssociateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociateWorkerOrders_ProjectId",
                table: "AssociateWorkerOrders",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Attendances_EmployeeId",
                table: "Employee_Attendances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GSTInvoices_ProjectId",
                table: "GSTInvoices",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProformaInvoices_ProjectId",
                table: "ProformaInvoices",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFees_ProjectId",
                table: "ProjectFees",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associate_Fees");

            migrationBuilder.DropTable(
                name: "AssociateWorkerOrders");

            migrationBuilder.DropTable(
                name: "Employee_Attendances");

            migrationBuilder.DropTable(
                name: "GSTInvoices");

            migrationBuilder.DropTable(
                name: "ProformaInvoices");

            migrationBuilder.DropTable(
                name: "ProjectFees");
        }
    }
}
