using Microsoft.EntityFrameworkCore.Migrations;

namespace OWT.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSkill",
                keyColumns: new[] { "ContactId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ContactSkill",
                keyColumns: new[] { "ContactId", "SkillId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "ContactSkill",
                columns: new[] { "ContactId", "SkillId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 2, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Devops");

            migrationBuilder.UpdateData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: ".Net");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContactSkill",
                keyColumns: new[] { "ContactId", "SkillId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ContactSkill",
                keyColumns: new[] { "ContactId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "ContactSkill",
                columns: new[] { "ContactId", "SkillId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "C#");

            migrationBuilder.UpdateData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "C#");
        }
    }
}
