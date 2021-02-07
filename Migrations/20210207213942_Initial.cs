using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiPageWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Address", "Name", "Note", "Number" },
                values: new object[,]
                {
                    { 1, "65 Lake St, Urbandale IA, 50256", "Bob Dylan", "Concert", "5154462487" },
                    { 2, "523 Fake St, Johnston IA, 50263", "Jon Rogers", "Plumber", "5154569577" },
                    { 3, "102 Jutland Ave, Clive IA, 50325", "Jake Bransgrove", "WBHS", "5157784255" },
                    { 4, "99 Island Road, Adel IA, 50893", "Grant Buchanan", "Best bud", "6634552258" },
                    { 5, "72 Lakeside Road, Ankeny IA, 50882", "Dad", "", "5622458855" },
                    { 6, "122 NW 80th, Urbandale IA, 50332", "Mum", "", "5625682253" },
                    { 7, "1660 NW 75th St, Clive IA 50325", "Abby", "Fiancee", "5159793742" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
