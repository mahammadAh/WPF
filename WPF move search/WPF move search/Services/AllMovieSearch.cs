using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using WPF_move_search.Model;

namespace WPF_move_search.Services
{
    class AllMovieSearch : IAllMovie
    {

        public string title { get; set; }

        public Search[] SearchByTitle()
        {
            AllMovie result;

            WebClient web = new WebClient();
            var request = $@"http://www.omdbapi.com/?apikey=f4e0873a&s={title}";
            var answer = web.DownloadString(request);
            result = JsonSerializer.Deserialize<AllMovie>(answer);

            return result.Search;
        }
    }
}
