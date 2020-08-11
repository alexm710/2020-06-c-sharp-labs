using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace football_top_scores_api_homework
{
    public class TopScorers
    {
        static Uri url1 = new Uri("http://api.football-data.org//v2/competitions/2021/scorers");
        static TopScorers.Root myDeserializedClass1 = new TopScorers.Root();

        static void GetPremierLeagueStats()
        {
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Add("X-Auth-Token", "700bbe845512489fbe80c732e309fa42");

                var jsonResponse = httpclient.GetStringAsync(url1);
                // deserialize
                myDeserializedClass1 = JsonConvert.DeserializeObject<TopScorers.Root>(jsonResponse.Result);
                Console.WriteLine(myDeserializedClass1);
            }
        }

        static void GetPremierLeagueScorers()
        {
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Add("X-Auth-Token", "700bbe845512489fbe80c732e309fa42");

                var jsonResponse = httpclient.GetStringAsync(url1);
                // deserialize
                myDeserializedClass1 = JsonConvert.DeserializeObject<Root>(jsonResponse.Result);
                Console.WriteLine(myDeserializedClass1);
            }
        }

        public static void GetScorersStandings()
        {
            foreach (var item in myDeserializedClass1.scorers)
            {
                foreach (var i in item.player.name)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        // scorer - players - players.name


        public class Filters
        {
            public int limit { get; set; }
        }

        public class Area
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Competition
        {
            public int id { get; set; }
            public Area area { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string plan { get; set; }
            public DateTime lastUpdated { get; set; }
        }

        public class Season
        {
            public int id { get; set; }
            public string startDate { get; set; }
            public string endDate { get; set; }
            public int currentMatchday { get; set; }
            public object winner { get; set; }
        }

        public class Player
        {
            public int id { get; set; }
            public string name { get; set; }
            public string firstName { get; set; }
            public object lastName { get; set; }
            public string dateOfBirth { get; set; }
            public string countryOfBirth { get; set; }
            public string nationality { get; set; }
            public string position { get; set; }
            public int? shirtNumber { get; set; }
            public DateTime lastUpdated { get; set; }
        }

        public class Team
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class Scorer
        {
            public Player player { get; set; }
            public Team team { get; set; }
            public int numberOfGoals { get; set; }
        }
        public class Root
        {
            public int count { get; set; }
            public Filters filters { get; set; }
            public Competition competition { get; set; }
            public Season season { get; set; }
            public List<Scorer> scorers { get; set; }
        }

    }
}
