using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EsVideo.Migrations
{
    /// <inheritdoc />
    public partial class Libreria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SetLibri",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anno = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetLibri", x => x.ISBN);
                });

            migrationBuilder.InsertData(
                table: "SetLibri",
                columns: new[] { "ISBN", "Anno", "Autore", "Genere", "Titolo" },
                values: new object[,]
                {
                    { "9780747543350", "1998", "J.K. Rowling", "Fantasy", "Harry Potter e la Camera dei Segreti" },
                    { "9780747546290", "1999", "J.K. Rowling", "Fantasy", "Harry Potter e il Prigioniero di Azkaban" },
                    { "9780747550990", "2000", "J.K. Rowling", "Fantasy", "Harry Potter e il Calice di Fuoco" },
                    { "9780747551002", "2003", "J.K. Rowling", "Fantasy", "Harry Potter e l'Ordine della Fenice" },
                    { "9780747591054", "2005", "J.K. Rowling", "Fantasy", "Harry Potter e il Principe Mezzosangue" },
                    { "9780747595861", "2007", "J.K. Rowling", "Fantasy", "Harry Potter e i Doni della Morte" },
                    { "9788804395544", "1866", "F�dor Dostoevskij", "Romanzo", "Delitto e castigo" },
                    { "9788804445678", "1886", "Robert Louis Stevenson", "Romanzo", "Il dottor Jekyll e Mr. Hyde" },
                    { "9788804490279", "1937", "J.R.R. Tolkien", "Fantasy", "Lo Hobbit" },
                    { "9788804504867", "1972", "Richard Adams", "Romanzo", "La collina dei conigli" },
                    { "9788804512763", "1954", "J.R.R. Tolkien", "Fantasy", "Il signore degli anelli" },
                    { "9788804512770", "1996", "George R.R. Martin", "Fantasy", "Il trono di spade" },
                    { "9788804516006", "1876", "Mark Twain", "Romanzo", "Le avventure di Tom Sawyer" },
                    { "9788804516013", "1884", "Mark Twain", "Romanzo", "Le avventure di Huckleberry Finn" },
                    { "9788804527101", "1898", "Henry James", "Romanzo", "Il giro di vite" },
                    { "9788804527102", "1830", "Stendhal", "Romanzo", "Il rosso e il nero" },
                    { "9788804543453", "1950", "C.S. Lewis", "Fantasy", "Le cronache di Narnia" },
                    { "9788804602089", "1945", "George Orwell", "Romanzo", "La fattoria degli animali" },
                    { "9788804602492", "1870", "Jules Verne", "Avventura", "Venti mila leghe sotto i mari" },
                    { "9788804602508", "1868", "Jules Verne", "Avventura", "I figli del capitano Grant" },
                    { "9788804602515", "1874", "Jules Verne", "Avventura", "L'isola misteriosa" },
                    { "9788804612658", "1967", "Gabriel Garc�a M�rquez", "Romanzo", "Cent'anni di solitudine" },
                    { "9788804613092", "1857", "Gustave Flaubert", "Romanzo", "Madame Bovary" },
                    { "9788804616427", "1967", "Michail Bulgakov", "Romanzo", "Il maestro e Margherita" },
                    { "9788804618728", "1952", "Ernest Hemingway", "Romanzo", "Il vecchio e il mare" },
                    { "9788804619169", "1320", "Dante Alighieri", "Poesia epica", "Divina Commedia" },
                    { "9788804623760", "1869", "Lev Tolstoj", "Romanzo", "Guerra e Pace" },
                    { "9788804631154", "1844", "Alexandre Dumas", "Romanzo", "Il conte di Montecristo" },
                    { "9788804660803", "1759", "Laurence Sterne", "Romanzo comico", "Vita e opinioni di Tristram Shandy, gentiluomo" },
                    { "9788804677252", "1926", "Agatha Christie", "Romanzo giallo", "L'assassinio di Roger Ackroyd" },
                    { "9788804680497", "1877", "Lev Tolstoj", "Romanzo", "Anna Karenina" },
                    { "9788804705854", "1942", "Albert Camus", "Romanzo", "Lo straniero" },
                    { "9788806140396", "1890", "Oscar Wilde", "Romanzo", "Il ritratto di Dorian Gray" },
                    { "9788807821196", "1847", "Emily Bront�", "Romanzo", "Cime tempestose" },
                    { "9788807900825", "1925", "F. Scott Fitzgerald", "Romanzo", "Il grande Gatsby" },
                    { "9788808222830", "1949", "George Orwell", "Distopia", "1984" },
                    { "9788817115373", "1851", "Herman Melville", "Romanzo", "Moby Dick" },
                    { "9788817179610", "1605", "Miguel de Cervantes", "Romanzo", "Don Chisciotte" },
                    { "9788817848474", "1925", "Franz Kafka", "Romanzo", "Il processo" },
                    { "9788842904456", "1977", "Terry Brooks", "Fantasy", "La spada di Shannara" },
                    { "9788842912222", "1990", "Terry Brooks", "Fantasy", "Gli eredi di Shannara" },
                    { "9788842914233", "1992", "Terry Brooks", "Fantasy", "La regina degli elfi di Shannara" },
                    { "9788842918187", "1993", "Terry Brooks", "Fantasy", "I Talismani di Shannara" },
                    { "9788842918194", "1992", "Terry Brooks", "Fantasy", "La Canzone di Shannara" },
                    { "9788845241391", "1951", "J.D. Salinger", "Romanzo", "Il giovane Holden" },
                    { "9788845243227", "1980", "Umberto Eco", "Romanzo giallo", "Il nome della rosa" },
                    { "9788845272814", "1943", "Antoine de Saint-Exup�ry", "Romanzo", "Il Piccolo Principe" },
                    { "9788877827027", "1997", "J.K. Rowling", "Fantasy", "Harry Potter e la Pietra Filosofale" },
                    { "9788882892547", "1813", "Jane Austen", "Romanzo", "Orgoglio e Pregiudizio" },
                    { "9788899060687", "1904", "Emilio Salgari", "Avventura", "La regina dei Caraibi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetLibri");
        }
    }
}
