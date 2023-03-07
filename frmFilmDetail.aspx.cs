using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movie
{
    public partial class frmFilmDetail : System.Web.UI.Page
    {
        List<Film> films = Database.readDbTable();
        public static Film film;
        int index = frmFilms.getIndex();

        public const String VIDEO_URL = @"https://api.themoviedb.org/3/movie/{0}/videos?api_key=a07e22bc18f5cb106bfe4cc1f83ad8ed";

        protected void Page_Load(object sender, EventArgs e)
        {
            film = films.ElementAt(index);

            title.Text = film.title;
            description.Text = film.overview;
            langage.Text = film.original_language;
            voteAv.Text = film.vote_average.ToString();
            date.Text = film.release_date;
            vote.Text = film.vote_count.ToString();
            video.Attributes["src"] = String.Format("https://www.youtube.com/embed/{0}", youtubeKey());
        }


        public String youtubeKey()

        {

            String reponse = "";
            String youtubeKey = "";

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    reponse = webClient.DownloadString(String.Format(VIDEO_URL, film.id));
                }

                using (JsonDocument document = JsonDocument.Parse(reponse))
                {
                    JsonElement root = document.RootElement;
                    JsonElement resultsList = root.GetProperty("results");

                    int i = 0;
                    while (true)
                    {
                        String type = resultsList[i].GetProperty("type").ToString();
                        youtubeKey = resultsList[i].GetProperty("key").ToString();
                        if (type.Equals("Clip"))
                        {
                            break;
                        }
                        i++;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return youtubeKey;
        }

    }
}