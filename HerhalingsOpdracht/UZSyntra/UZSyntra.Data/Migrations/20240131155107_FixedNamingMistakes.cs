using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UZSyntra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedNamingMistakes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bed_Room_RoomID",
                table: "Bed");

            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_Bed_BedID",
                table: "Intakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_Patient_PatientID",
                table: "Intakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Departments_DepartmentID",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bed",
                table: "Bed");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "Bed",
                newName: "Beds");

            migrationBuilder.RenameIndex(
                name: "IX_Room_DepartmentID",
                table: "Rooms",
                newName: "IX_Rooms_DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Bed_RoomID",
                table: "Beds",
                newName: "IX_Beds_RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beds",
                table: "Beds",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Beds_Rooms_RoomID",
                table: "Beds",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_Beds_BedID",
                table: "Intakes",
                column: "BedID",
                principalTable: "Beds",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_Patients_PatientID",
                table: "Intakes",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Departments_DepartmentID",
                table: "Rooms",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beds_Rooms_RoomID",
                table: "Beds");

            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_Beds_BedID",
                table: "Intakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_Patients_PatientID",
                table: "Intakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Departments_DepartmentID",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beds",
                table: "Beds");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "Beds",
                newName: "Bed");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_DepartmentID",
                table: "Room",
                newName: "IX_Room_DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Beds_RoomID",
                table: "Bed",
                newName: "IX_Bed_RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bed",
                table: "Bed",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bed_Room_RoomID",
                table: "Bed",
                column: "RoomID",
                principalTable: "Room",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_Bed_BedID",
                table: "Intakes",
                column: "BedID",
                principalTable: "Bed",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_Patient_PatientID",
                table: "Intakes",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Departments_DepartmentID",
                table: "Room",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
