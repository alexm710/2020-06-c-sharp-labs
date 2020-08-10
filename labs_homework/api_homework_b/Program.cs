using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;

namespace football_top_scorers_api
{
    class Program
    {
        static Uri url = new Uri("https://dugout.statsfc.com/api/v2/top-scorers?StatsFC-Key:c3WPZaLj1CH9raoSsFAMRfz7v9eqLNNsdzkkNMUL");
        //static Uri url = new Uri("https://dugout.statsfc.com/docs#top-scorers");

        static Root myDeserializedClass;

        static void Main(string[] args)
        {
            GetTopScorers();
            Thread.Sleep(2000);
            Console.WriteLine(myDeserializedClass.data[0]);
        }

        async static void GetTopScorers()
        {
            using (var httpclient = new HttpClient())
            {
                //httpclient.DefaultRequestHeaders.Add("X-StatsFC-Key: {c3WPZaLj1CH9raoSsFAMRfz7v9eqLNNsdzkkNMUL}");
                var jsonResponse = await httpclient.GetStringAsync(url);
                // deserialize
                myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonResponse);

                //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(data);
            }
        }

        //async static void GetPremierLeagueTable()
        //{
        //    using (var httpclient = new HttpClient())
        //    {
        //        var jsonResponse = await httpclient.GetStringAsync(url);
        //        // deserialize
        //        myDeserializedClassStandings = JsonConvert.DeserializeObject<Root>(jsonResponse);
        //    }
        //}

        public class Player
        {
            public string name { get; set; }
        }

        public class Team
        {
            public string name { get; set; }
            public string shortName { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public Player player { get; set; }
            public Team team { get; set; }
            public int goals { get; set; }
        }

        public class Root
        {
            public List<Datum> data { get; set; }
        }

    }
}



