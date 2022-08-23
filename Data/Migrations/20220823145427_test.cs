using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobRoles",
                columns: table => new
                {
                    JobRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRoles", x => x.JobRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactDetailsId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobRoleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_JobRoles_JobRoleId",
                        column: x => x.JobRoleId,
                        principalTable: "JobRoles",
                        principalColumn: "JobRoleId");
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    EmployeeDetailsId = table.Column<int>(type: "int", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: false),
                    HomePhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.EmployeeDetailsId);
                    table.ForeignKey(
                        name: "FK_ContactDetails_Employee_EmployeeDetailsId",
                        column: x => x.EmployeeDetailsId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "JobRoleId", "JobTitle" },
                values: new object[,]
                {
                    { 1, "CEO" },
                    { 2, "CTO" },
                    { 3, "C3PO" },
                    { 4, "Manager" },
                    { 5, "Supervisor" },
                    { 6, "Contracted" },
                    { 7, "In House" },
                    { 8, "Associate" },
                    { 9, "Nobody" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_JobRoleId",
                table: "Employee",
                column: "JobRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "JobRoles");
        }
    }
}
