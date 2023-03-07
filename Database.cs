using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Web;

namespace Movie
{
    public static class Database
    {
        
        // Initiate a private database connection
        static SQLiteConnection newConnection()
        {
            string exFile = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(exFile);
            string path = Uri.UnescapeDataString(uri.Path);

            string databasePath = Path.GetDirectoryName(path) + "/films.db";

            // Create Sqlite database connection
            SQLiteConnection connection = new SQLiteConnection($"Data Source = {databasePath}; Version = 3;");
            

            return connection;
        }

        // Create a new movie table in the database
        static void createTable(SQLiteConnection connection)
        {
            // Open connection
            connection.Open();

            // Command to create table
            string create = "CREATE TABLE IF NOT EXISTS Film( id INT, original_title VARCHAR(20), overview VARCHAR, poster_path VARCHAR," +
                " release_date VARCHAR(20), original_language VARCHAR(20), popularity Float, title VARCHAR(20),video Bool, vote_average Float, vote_count INT )"; ;

            // Initiate command
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = create;
            command.ExecuteNonQuery();

            // Close connection
            connection.Close();
        }

        // Insert data in the database
        static void updateDb(SQLiteConnection connection, Film film)
        {
            // Open connection
            connection.Open();

            // Update command
            string update = "INSERT INTO film (id, original_title, overview, poster_path, release_date," +
                " original_language, popularity, title, video,vote_average,vote_count) VALUES (@id, @original_title, @overview, @poster_path," +
                "@release_date, @original_language, @popularity, @title, @video, @vote_average, @vote_count);";

            //Initiate command
            SQLiteCommand updateCommand = new SQLiteCommand(update, connection);
            updateCommand.Parameters.AddWithValue("@id", film.id);
            updateCommand.Parameters.AddWithValue("@original_title", film.original_title);
            updateCommand.Parameters.AddWithValue("@overview", film.overview);
            updateCommand.Parameters.AddWithValue("@poster_path", film.poster_path);
            updateCommand.Parameters.AddWithValue("@release_date", film.release_date);
            updateCommand.Parameters.AddWithValue("@original_language", film.original_language);
            updateCommand.Parameters.AddWithValue("@popularity", film.popularity);
            updateCommand.Parameters.AddWithValue("@title", film.title);
            updateCommand.Parameters.AddWithValue("@video", film.video);
            updateCommand.Parameters.AddWithValue("@vote_average", film.vote_average);
            updateCommand.Parameters.AddWithValue("@vote_count", film.vote_count);


            updateCommand.ExecuteNonQuery();

            // Close connection
            connection.Close();
        }

        static List<Film> readTable()
        {
            SQLiteConnection connection = newConnection();
            connection.Open();
            // Create dynamic film list
            List<Film> films = new List<Film>();

            // Select movies from database
            SQLiteCommand readCommand = new SQLiteCommand("Select * From film", connection);

            //Read movies in database
            SQLiteDataReader readDb = readCommand.ExecuteReader();

            //Insert movies in list
            while (readDb.Read())
            {
                Film film = new Film();
                film.id = readDb.GetInt16(0);
                film.original_title = readDb.GetString(1);
                film.overview = readDb.GetString(2);
                film.poster_path = readDb.GetString(3);
                film.release_date = readDb.GetString(4);
                film.original_language = readDb.GetString(5);
                film.popularity = readDb.GetFloat(6);
                film.title = readDb.GetString(7);
                film.video = readDb.GetBoolean(8);
                film.vote_average = readDb.GetFloat(9);
                film.vote_count = readDb.GetInt16(10);
                films.Add(film);

            }

            connection.Close();
            // Return film list
            return films;
        }


        // get database connection
        public static SQLiteConnection getDbConnection() => newConnection();

        // get create table command
        public static void createDbTable(SQLiteConnection connection) => createTable(connection);

        // get update table command
        public static void updateDatabase(SQLiteConnection connection, Film film) => updateDb(connection, film);

        //get read table command
        public static List<Film> readDbTable() => readTable();
    }
}