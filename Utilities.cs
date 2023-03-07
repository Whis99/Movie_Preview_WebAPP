﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;
using System.Text.Json;

namespace Movie
{
    public static class Utilities
    {
        private static string siteLink;

        public static List<Film> getMovieDbList()
        {
            String reponse = "";
            List<Film> Films = null;
            siteLink = "https://api.themoviedb.org/3/movie/now_playing?api_key=a07e22bc18f5cb106bfe4cc1f83ad8ed";
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    reponse = webClient.DownloadString(siteLink);
                }

                using (JsonDocument document = JsonDocument.Parse(reponse))
                {
                    JsonElement root = document.RootElement;
                    JsonElement resultsList = root.GetProperty("results");
                    Films = JsonSerializer.Deserialize<List<Film>>(resultsList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Films;
        }


        public static bool IsConnectedToInternet()
        {
            string host = "www.google.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }

        public static void networkStatus(Panel panel)
        {
            if (IsConnectedToInternet())
            {
                panel.BackColor = Color.Blue;
            }
        }

    }

}