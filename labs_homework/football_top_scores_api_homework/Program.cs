//using football_top_scores_api_homework;
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
        static Uri url = new Uri("http://api.football-data.org/v2/competitions/2021/standings");


        static Root myDeserializedClass = new Root();

        static void Main(string[] args)
        {
            GetPremierLeagueTable();
            GetStandings();
            //TopScorers.GetScorersStandings();

            //Console.WriteLine("hi");

            //Thread.Sleep(2000);

            // Console.WriteLine(myDeserializedClass.currentSeason);

        }

        static void GetPremierLeagueTable()
        {
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Add("X-Auth-Token","700bbe845512489fbe80c732e309fa42");

                var jsonResponse = httpclient.GetStringAsync(url);
                // deserialize
                myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonResponse.Result);
                Console.WriteLine(myDeserializedClass);
            }
        }


        //Root - > standings -> table.position/team.... -> team


        static void GetStandings()
        {
            foreach (var item in myDeserializedClass.standings)
            {
                foreach (var i in item.table)
                {
                    Console.WriteLine($"{i.position}. {i.team.name}");
                }
            }
            //foreach (var item in myDeserializedClass.standings)
            //{
            //    foreach (var i in item.table)
            //    {
            //        Console.WriteLine(i.team.name);
            //    }
            //}
        }

        static void GetTopScorers()
        {

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

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 


        public class Filters
        {
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

        public class Team
        {
            public int id { get; set; }
            public string name { get; set; }
            public string crestUrl { get; set; }
        }

        public class Table
        {
            public int position { get; set; }
            public Team team { get; set; }
            public int playedGames { get; set; }
            public int won { get; set; }
            public int draw { get; set; }
            public int lost { get; set; }
            public int points { get; set; }
            public int goalsFor { get; set; }
            public int goalsAgainst { get; set; }
            public int goalDifference { get; set; }
        }
        public class Standing
        {
            public string stage { get; set; }
            public string type { get; set; }
            public object group { get; set; }
            public List<Table> table { get; set; }
        }
        //Root - > standings -> table.position/team.... -> team
        public class Root
        {
            public Filters filters { get; set; }
            public Competition competition { get; set; }
            public Season season { get; set; }
            public List<Standing> standings { get; set; }
        }



    }
}