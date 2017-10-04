using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AIRA.UI.Migrations
{
    public partial class ApplicatinDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioReview_Portfolio_PortfolioId",
                table: "PortfolioReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioReview",
                table: "PortfolioReview");

            migrationBuilder.RenameTable(
                name: "PortfolioReview",
                newName: "Reviews");

            migrationBuilder.RenameIndex(
                name: "IX_PortfolioReview_PortfolioId",
                table: "Reviews",
                newName: "IX_Reviews_PortfolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                    table.ForeignKey(
                        name: "FK_News_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_BlogId",
                table: "News",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Portfolio_PortfolioId",
                table: "Reviews",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Portfolio_PortfolioId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "PortfolioReview");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_PortfolioId",
                table: "PortfolioReview",
                newName: "IX_PortfolioReview_PortfolioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioReview",
                table: "PortfolioReview",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioReview_Portfolio_PortfolioId",
                table: "PortfolioReview",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
