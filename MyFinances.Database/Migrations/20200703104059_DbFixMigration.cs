using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFinances.Database.Migrations
{
    public partial class DbFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FavorityAssets",
                table: "FavorityAssets");

            migrationBuilder.RenameTable(
                name: "FavorityAssets",
                newName: "FavoriteAssets");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "FavoriteAssets",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AssetId",
                table: "FavoriteAssets",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteAssets",
                table: "FavoriteAssets",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteAssets",
                table: "FavoriteAssets");

            migrationBuilder.RenameTable(
                name: "FavoriteAssets",
                newName: "FavorityAssets");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "FavorityAssets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssetId",
                table: "FavorityAssets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavorityAssets",
                table: "FavorityAssets",
                column: "Id");
        }
    }
}
