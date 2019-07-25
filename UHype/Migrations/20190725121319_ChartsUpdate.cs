using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UHype.Migrations
{
    public partial class ChartsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comorbidity",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Medication",
                table: "Charts");

            migrationBuilder.AlterColumn<bool>(
                name: "BpControl",
                table: "Charts",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<bool>(
                name: "AtrialFib",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "BUN",
                table: "Charts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "CAD",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CKD",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cholesterol",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Creatinine",
                table: "Charts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Dementia",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Diabetes",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Diabetics",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "HDL",
                table: "Charts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "HeartFail",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HyperLip",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Hypertensives",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "LDL",
                table: "Charts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LabCholesterol",
                table: "Charts",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LabDate",
                table: "Charts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OtherMeds",
                table: "Charts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Pain",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Platelets",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Prostate",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "RecordedPulseBp",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Stroke",
                table: "Charts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Trigs",
                table: "Charts",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtrialFib",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "BUN",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "CAD",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "CKD",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Cholesterol",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Creatinine",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Dementia",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Diabetes",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Diabetics",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "HDL",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "HeartFail",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "HyperLip",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Hypertensives",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "LDL",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "LabCholesterol",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "LabDate",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "OtherMeds",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Pain",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Platelets",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Prostate",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "RecordedPulseBp",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Stroke",
                table: "Charts");

            migrationBuilder.DropColumn(
                name: "Trigs",
                table: "Charts");

            migrationBuilder.AlterColumn<byte>(
                name: "BpControl",
                table: "Charts",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "Comorbidity",
                table: "Charts",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medication",
                table: "Charts",
                maxLength: 150,
                nullable: true);
        }
    }
}
