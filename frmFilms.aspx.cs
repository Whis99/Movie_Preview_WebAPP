using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie
{
    
    public partial class frmFilms : System.Web.UI.Page
    {
        public static SQLiteConnection connection;
        List<Film> films = Database.readDbTable();
        public static Film film;
        static int index = 0;

        
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);

            if (Utilities.IsConnectedToInternet())
            {

                Utilities.networkStatus(Panel);
                loadFilm(index);

            }
            else
            {
                loadFilm(index);
            }
        }

        public void loadFilm(int index)
        {
            try
            {
                if (index >= 0 && index <= films.Count)
                {
                    film = films.ElementAt(index);


                    title.Text = film.title;
                    description.Text = film.overview;
                    langage.Text = film.original_language;
                    voteAv.Text = film.vote_average.ToString();
                    date.Text = film.release_date;
                    mPoster.ImageUrl = "https://image.tmdb.org/t/p/w342" + film.poster_path;
                }
                else
                {
                    index = 0;
                    film = films.ElementAt(index);


                    title.Text = film.title;
                    description.Text = film.overview;
                    langage.Text = film.original_language;
                    voteAv.Text = film.vote_average.ToString();
                    date.Text = film.release_date;

                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }



        }

        protected void previous_Click(object sender, EventArgs e)
        {
            index --;
            loadFilm(index);
        }

        protected void next_Click(object sender, EventArgs e)
        {
            index ++;
            loadFilm(index);
        }


        public static int getIndex() => index;
    }
}