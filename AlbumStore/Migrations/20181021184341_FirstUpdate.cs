using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumStore.Migrations
{
    public partial class FirstUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Artist_ArtistID",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Album_Decade_DecadeID",
                table: "Album");

            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Genre_GenreID",
                table: "Artist");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Album_AlbumID",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Format_FormatID",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Format",
                table: "Format");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Decade",
                table: "Decade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist",
                table: "Artist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Album",
                table: "Album");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "Format",
                newName: "Formats");

            migrationBuilder.RenameTable(
                name: "Decade",
                newName: "Decades");

            migrationBuilder.RenameTable(
                name: "Artist",
                newName: "Artists");

            migrationBuilder.RenameTable(
                name: "Album",
                newName: "Albums");

            migrationBuilder.RenameIndex(
                name: "IX_Product_FormatID",
                table: "Products",
                newName: "IX_Products_FormatID");

            migrationBuilder.RenameIndex(
                name: "IX_Product_AlbumID",
                table: "Products",
                newName: "IX_Products_AlbumID");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_GenreID",
                table: "Artists",
                newName: "IX_Artists_GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_Album_DecadeID",
                table: "Albums",
                newName: "IX_Albums_DecadeID");

            migrationBuilder.RenameIndex(
                name: "IX_Album_ArtistID",
                table: "Albums",
                newName: "IX_Albums_ArtistID");

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "Artists",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Artists",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Formats",
                table: "Formats",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decades",
                table: "Decades",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artists",
                table: "Artists",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistID",
                table: "Albums",
                column: "ArtistID",
                principalTable: "Artists",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Decades_DecadeID",
                table: "Albums",
                column: "DecadeID",
                principalTable: "Decades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Genres_GenreID",
                table: "Artists",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Albums_AlbumID",
                table: "Products",
                column: "AlbumID",
                principalTable: "Albums",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Formats_FormatID",
                table: "Products",
                column: "FormatID",
                principalTable: "Formats",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistID",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Decades_DecadeID",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Genres_GenreID",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Albums_AlbumID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Formats_FormatID",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Formats",
                table: "Formats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Decades",
                table: "Decades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artists",
                table: "Artists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Artists");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "Formats",
                newName: "Format");

            migrationBuilder.RenameTable(
                name: "Decades",
                newName: "Decade");

            migrationBuilder.RenameTable(
                name: "Artists",
                newName: "Artist");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Album");

            migrationBuilder.RenameIndex(
                name: "IX_Products_FormatID",
                table: "Product",
                newName: "IX_Product_FormatID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_AlbumID",
                table: "Product",
                newName: "IX_Product_AlbumID");

            migrationBuilder.RenameIndex(
                name: "IX_Artists_GenreID",
                table: "Artist",
                newName: "IX_Artist_GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_DecadeID",
                table: "Album",
                newName: "IX_Album_DecadeID");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistID",
                table: "Album",
                newName: "IX_Album_ArtistID");

            migrationBuilder.AlterColumn<int>(
                name: "GenreID",
                table: "Artist",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Format",
                table: "Format",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Decade",
                table: "Decade",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist",
                table: "Artist",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Album",
                table: "Album",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Artist_ArtistID",
                table: "Album",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Decade_DecadeID",
                table: "Album",
                column: "DecadeID",
                principalTable: "Decade",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Genre_GenreID",
                table: "Artist",
                column: "GenreID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Album_AlbumID",
                table: "Product",
                column: "AlbumID",
                principalTable: "Album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Format_FormatID",
                table: "Product",
                column: "FormatID",
                principalTable: "Format",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
