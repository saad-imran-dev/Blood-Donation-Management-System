using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDMS.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RejectBag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RejectDonor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.DiseaseId);
                });

            migrationBuilder.CreateTable(
                name: "Donors",
                columns: table => new
                {
                    Cnic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donors", x => x.Cnic);
                    table.ForeignKey(
                        name: "FK_Donors_Areas_AreaCode",
                        column: x => x.AreaCode,
                        principalTable: "Areas",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Organizations_Areas_AreaCode",
                        column: x => x.AreaCode,
                        principalTable: "Areas",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BloodCamps",
                columns: table => new
                {
                    OrgCode = table.Column<int>(type: "int", nullable: false),
                    AreaCode = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    beds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodCamps", x => new { x.OrgCode, x.AreaCode });
                    table.ForeignKey(
                        name: "FK_BloodCamps_Areas_AreaCode",
                        column: x => x.AreaCode,
                        principalTable: "Areas",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BloodCamps_Organizations_OrgCode",
                        column: x => x.OrgCode,
                        principalTable: "Organizations",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Emplopyees",
                columns: table => new
                {
                    Cnic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgCode = table.Column<int>(type: "int", nullable: false),
                    AreaCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emplopyees", x => x.Cnic);
                    table.ForeignKey(
                        name: "FK_Emplopyees_Areas_AreaCode",
                        column: x => x.AreaCode,
                        principalTable: "Areas",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emplopyees_Organizations_OrgCode",
                        column: x => x.OrgCode,
                        principalTable: "Organizations",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    SlotNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bedno = table.Column<int>(type: "int", nullable: false),
                    CanDonate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgCode = table.Column<int>(type: "int", nullable: false),
                    AreaCode = table.Column<int>(type: "int", nullable: false),
                    DonorCnic = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => x.SlotNo);
                    table.ForeignKey(
                        name: "FK_Slots_Areas_AreaCode",
                        column: x => x.AreaCode,
                        principalTable: "Areas",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Slots_Donors_DonorCnic",
                        column: x => x.DonorCnic,
                        principalTable: "Donors",
                        principalColumn: "Cnic",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Slots_Organizations_OrgCode",
                        column: x => x.OrgCode,
                        principalTable: "Organizations",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BloodBags",
                columns: table => new
                {
                    BagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGrp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    History = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodBags", x => x.BagId);
                    table.ForeignKey(
                        name: "FK_BloodBags_Slots_History",
                        column: x => x.History,
                        principalTable: "Slots",
                        principalColumn: "SlotNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestedBags",
                columns: table => new
                {
                    BagId = table.Column<int>(type: "int", nullable: false),
                    DiseaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestedBags", x => new { x.BagId, x.DiseaseId });
                    table.ForeignKey(
                        name: "FK_TestedBags_BloodBags_BagId",
                        column: x => x.BagId,
                        principalTable: "BloodBags",
                        principalColumn: "BagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestedBags_Diseases_DiseaseId",
                        column: x => x.DiseaseId,
                        principalTable: "Diseases",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodBags_History",
                table: "BloodBags",
                column: "History");

            migrationBuilder.CreateIndex(
                name: "IX_BloodCamps_AreaCode",
                table: "BloodCamps",
                column: "AreaCode");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_AreaCode",
                table: "Donors",
                column: "AreaCode");

            migrationBuilder.CreateIndex(
                name: "IX_Emplopyees_AreaCode",
                table: "Emplopyees",
                column: "AreaCode");

            migrationBuilder.CreateIndex(
                name: "IX_Emplopyees_OrgCode",
                table: "Emplopyees",
                column: "OrgCode");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AreaCode",
                table: "Organizations",
                column: "AreaCode");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_AreaCode",
                table: "Slots",
                column: "AreaCode");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_DonorCnic",
                table: "Slots",
                column: "DonorCnic");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_OrgCode",
                table: "Slots",
                column: "OrgCode");

            migrationBuilder.CreateIndex(
                name: "IX_TestedBags_DiseaseId",
                table: "TestedBags",
                column: "DiseaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodCamps");

            migrationBuilder.DropTable(
                name: "Emplopyees");

            migrationBuilder.DropTable(
                name: "TestedBags");

            migrationBuilder.DropTable(
                name: "BloodBags");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Donors");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Areas");
        }
    }
}
