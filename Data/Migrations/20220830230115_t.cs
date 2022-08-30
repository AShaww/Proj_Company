using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "JobRoles",
                columns: table => new
                {
                    JobRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobRoleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRoles", x => x.JobRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeDetailsId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    JobRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_JobRoles_JobRoleId",
                        column: x => x.JobRoleId,
                        principalTable: "JobRoles",
                        principalColumn: "JobRoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                columns: table => new
                {
                    EmployeeDetailsId = table.Column<int>(type: "int", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.EmployeeDetailsId);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Employees_EmployeeDetailsId",
                        column: x => x.EmployeeDetailsId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "JobRoleId", "JobRoleTitle" },
                values: new object[,]
                {
                    { 1, "Illuminati" },
                    { 2, "CEO" },
                    { 3, "CTO" },
                    { 4, "C3PO" },
                    { 5, "Head of Department" },
                    { 6, "Manager" },
                    { 7, "Supervisor" },
                    { 8, "Lacky" },
                    { 9, "Coffee Boy" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "EmployeeDetailsId", "FirstName", "GenderId", "JobRoleId", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "Pepper", 2, 2, "Potts" },
                    { 2, 2, "Amelia", 2, 2, "Kent" },
                    { 3, 3, "Jane", 2, 3, "Dough" },
                    { 4, 4, "Booklyn", 2, 4, "Street" },
                    { 5, 5, "Robin", 2, 5, "Steal'ums" },
                    { 6, 6, "Luke", 1, 1, "Skycrawler" },
                    { 7, 7, "Rob", 1, 7, "Banks" },
                    { 8, 8, "Resta", 1, 8, "Soul" },
                    { 9, 9, "Amir", 1, 9, "Shaw" },
                    { 10, 10, "Jack", 1, 9, "Daniels" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeDetails",
                columns: new[] { "EmployeeDetailsId", "Address", "MobileNumber" },
                values: new object[,]
                {
                    { 1, "31 Street", "+447982892893" },
                    { 2, "Flat 921a, Monty Road", "+447982892893" },
                    { 3, "6 Sewer Lake", "+447982892893" },
                    { 4, "2 Random Cave Entrance", "+447982892893" },
                    { 5, "24 Bobs Hut", "+447982892893" },
                    { 6, "53 Deck of Houses", "+447982892893" },
                    { 7, "12 Word on the street", "+447982892893" },
                    { 8, "534 Maybe Im good at this? Road", "+447982892893" },
                    { 9, "92 Lavender park", "+447982892893" },
                    { 10, "EYY 9b Hey mamba Lane", "+447982892893" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobRoleId",
                table: "Employees",
                column: "JobRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "JobRoles");
        }
    }
}
