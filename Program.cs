using Microsoft.Data.Sqlite;

/*      
*--------------------------------------------------------------------
* 	        File name: QueryBuilding
*           Project name: Lab 3, QueryBuilder
*--------------------------------------------------------------------
*           Author’s name and email: Brooke Acevedo acevedob@etsu.edu			
*           Course-Section: Server Side Web Programming
*           Creation Date: 09-22-2023
* -------------------------------------------------------------------
*/

namespace QueryBuilding
{
    internal class Program
    {
        static string root = FileRoot.Root;
        static string dbPath = root + "\\data\\data.db";
        static string connectionString = $"Data Source={dbPath}";

        SqliteConnection? connection;

        public Program(string dbPath)
        {
            connection = new SqliteConnection(connectionString);
            connection.Open();
        }

        public static void Main(string[] args)
        {
            var queryBuilder = new QueryBuilder(connectionString);

            var newPokemon = new Pokemon()
            {
                DexNumber = 98777,
                Name = "Cool new Pokemon",
                Form = "female"

            };

            var newBannedGame = new BannedGame()
            {
                Title = "Baldurs Gate 3",
                Series = "Baldurs Gate",
                Country = "United States",
                Details = "Idk it's just on my mind rn"

            };

            List<Pokemon> pokemons = new List<Pokemon>()
            {
                new Pokemon { DexNumber = 1, Name = "Fancy Pants", Form = "Female", Type1 = "Dragon", Type2 = "I dont fucking know pokemon types"},
                new Pokemon { DexNumber = 2, Name = "A Jolly Good Show", Form = "Male", Type1 = "Dragon these nuts on your face", Type2 = "I dont fucking know pokemon types"},
                new Pokemon { DexNumber = 3, Name = "An Englishman Named Gavin", Form = "Male(?)", Type1 = "WHY WOULD YOU ASK ME THAT", Type2 = "I dont fucking know pokemon types"}

            };

            List<BannedGame> bannedGames = new List<BannedGame>()
            {
                new BannedGame { Title = "Baldurs Gate 3", Series = "Baldurs Gate", Country = "Italy", Details = "I might be obsessed with this game."},
                new BannedGame { Title = "Halo 3", Series = "Halo", Country = "Britain", Details = "Only the best game of all time. Banned for being too perfect."},
                new BannedGame { Title = "Minecraft", Series = "Minecraft", Country = "Russia", Details = "Idk I was just listening to minecraft music."},
                new BannedGame { Title = "Dead Cells", Series = "Dead Cells", Country = "United States", Details = "This game makes me unfathomably angry."}

            };

            // Deletes all the banned games and pokemon
            queryBuilder.DeleteAll<BannedGame>();
            queryBuilder.DeleteAll<Pokemon>();

            Console.WriteLine("\n");

            // Creates a whole list of pokemon and banned games
            foreach (Pokemon freshPokemon in pokemons)
            {
                queryBuilder.Create(freshPokemon);
            }

            foreach (BannedGame game in bannedGames)
            {
                queryBuilder.Create(game);
            }

            Console.WriteLine("\n");

            // Creates the singular pokemon and banned game
            queryBuilder.Create(newPokemon);
            queryBuilder.Create(newBannedGame);


            

        }
    }
}