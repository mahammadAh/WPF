using System;
using System.Collections.Generic;
using System.Text;
using WPF_move_search.Model;
using System.Net;
using System.Text.Json;

namespace WPF_move_search.Services
{
   public class SelectedMovieSearch : IMovieSearcher
    {
        public string title { get; set; }


        public Movie SearchByTitle()
        {
            Movie result;

            WebClient web = new WebClient();
            var request = $@"http://www.omdbapi.com/?apikey=f4e0873a&t={title}";
            var answer = web.DownloadString(request);
            result = JsonSerializer.Deserialize<Movie>(answer);

            return result;
        }
    }
}
