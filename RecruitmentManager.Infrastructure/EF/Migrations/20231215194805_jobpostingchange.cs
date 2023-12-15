using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitmentManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class jobpostingchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCandidatesSelected",
                table: "JobPostings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCandidatesSelected",
                table: "JobPostings");
        }
    }
}
