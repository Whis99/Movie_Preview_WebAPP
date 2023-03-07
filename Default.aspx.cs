using System;
using System.Data.SQLite;

namespace Movie
{
    public partial class Default : System.Web.UI.Page
    {
        public static SQLiteConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            runDatabase();
        }

        public void runDatabase()
        {
            // Create the connection
            connection = Database.getDbConnection();
            //Create table
            Database.createDbTable(connection);

            // Threading, while screen is loading update
            // the database if connected to internet
            if (Utilities.IsConnectedToInternet())
            {
                foreach (Film film in Utilities.getMovieDbList())
                {
                    Database.updateDatabase(connection, film);

                }
            }
        }

    }
}