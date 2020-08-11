using football_from_scratch_core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace football_from_scratch_core
{
    class Program
    {
        static List<Player> players = new List<Player>();
        static Player player = new Player();
        static Uri url = new Uri("https://localhost:44312/api/Players");

        static Player newPlayer = new Player()
        {
            PlayerId = 8,
            PlayerName = "Sergio Aguero",
            PlayerAge = 29,
            PlayerPosition = "Striker",
            TeamName = "Manchester City"
        };
        static void Main(string[] args)
        {
            ////Async Get One Customer
            //GetPlayerAsync("3");
            //Thread.Sleep(8000);
            //Console.WriteLine($"ID: {player.PlayerId} has returned - Player's name is {player.PlayerName} \n{player.PlayerName} is {player.PlayerAge} years old. They play for {player.TeamName} and their position is {player.PlayerPosition}\n");


            //// get all customers
            //Console.WriteLine("---All Football Players---");
            //GetAllPlayersAsync();
            //Thread.Sleep(5000);
            //foreach (var item in players)
            //{
            //    Console.WriteLine(item.PlayerName);
            //};


            // Post a new Player

            Thread.Sleep(7000);
            Console.WriteLine("\n---Adding a new player to the database---");
            PostPlayerAsync(newPlayer);
            Thread.Sleep(4000);

            //// Delete a Player
            //Console.WriteLine("---Deleting a Player from the database---");
            //DeletePlayerAsync(5);
            //Thread.Sleep(2000);
        }

        // 2 Get methods to read a players data
        static async void GetPlayerAsync(string playerId)
        {
            using (var httpclient = new HttpClient())
            {
                var playerData = await httpclient.GetStringAsync($"{url}/{playerId}");
                player = JsonConvert.DeserializeObject<Player>(playerData);
            }
        }

        static void GetAllPlayers()
        {
            using (var httpclient = new HttpClient())
            {
                var customerData = httpclient.GetStringAsync(url);
                players = JsonConvert.DeserializeObject<List<Player>>(customerData.Result);
            }
        }

        static async void GetAllPlayersAsync()
        {
            using (var httpclient = new HttpClient())
            {
                var customerData = await httpclient.GetStringAsync(url);
                players = JsonConvert.DeserializeObject<List<Player>>(customerData);
            }
        }

        // check the player exists in db
        static bool PlayerExists(int playerId)
        {
            GetAllPlayers();
            player = null;
            player = players.Find(c => c.PlayerId == playerId);
            if (player != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // using post to add a player to db
        static void PostPlayerAsync(Player newPlayer)
        {
            // check customer does not exist
            if (!PlayerExists(newPlayer.PlayerId))
            {
                // first serialise our player to JSON
                string newPlayerAsJson = JsonConvert.SerializeObject(newPlayer, Formatting.Indented);
                // convert this to http
                var httpcontent = new StringContent(newPlayerAsJson);
                // add headers before send
                httpcontent.Headers.ContentType.MediaType = "application/json";
                httpcontent.Headers.ContentType.CharSet = "UTF-8";

                // send data
                using (var httpclient = new HttpClient())
                {
                    var httpresponse = httpclient.PostAsync(url, httpcontent);
                    Console.WriteLine($"Success status is {httpresponse.Result.IsSuccessStatusCode}");
                    if (httpresponse.Result.IsSuccessStatusCode == true)
                    {
                        Console.WriteLine($"Player added with ID {newPlayer.PlayerId}");
                        players.Add(newPlayer);
                    }
                    else
                    {
                        Console.WriteLine($"Player already exists - {newPlayer.PlayerId}");
                    }
                }
            }
        }

            // using post to update a players record in db
            static async void UpdatePlayerAsync(Player updatePlayer)
            {
                if (PlayerExists(updatePlayer.PlayerId) == true)
                {
                    string updatePlayerAsJson = JsonConvert.SerializeObject(updatePlayer);

                    // Convert to HTTP
                    var httpContent = new StringContent(updatePlayerAsJson);

                    // Add headers before send
                    httpContent.Headers.ContentType.MediaType = "application/json";
                    httpContent.Headers.ContentType.CharSet = "UTF-8";

                    // Send data
                    using (var httpClient = new HttpClient())
                    {
                        var httpResponse = await httpClient.PutAsync($"{url}/{updatePlayer.PlayerId}", httpContent);
                        if (httpResponse.IsSuccessStatusCode)
                        {
                            Console.WriteLine($"Player record: {updatePlayer.PlayerId}, has successfully updated");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Player with ID: {updatePlayer.PlayerId} does not exist");
                }
            }

            // simple delete method to delete players record
            static async void DeletePlayerAsync(int playerId)
            {
                if (PlayerExists(playerId) == true)
                {
                    // Send Data
                    using (var httpClient = new HttpClient())
                    {
                        var httpResponse = await httpClient.DeleteAsync($"{url}/{playerId}");
                        if (httpResponse.IsSuccessStatusCode)
                        {
                            Console.WriteLine($"Record {playerId} successfully deleted");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Player with ID: {playerId} cannot be deleted");
                }
            }
        }
    }
