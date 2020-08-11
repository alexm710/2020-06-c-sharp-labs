using dog_owner_entity_first_code_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
//using dog_owner_entity_first_code_api.Models;

namespace dog_owner_entity_first_code_api
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Owners> owners = new List<Owners>();
            List<Dogs> dogs = new List<Dogs>();

            using (var db = new DogDBContext())
            {

                // refresh entries
                dogs = db.Dogs.ToList();
                owners = db.Owners.ToList();

                dogs.ForEach(d => Console.WriteLine($" Dog {d.DogsId} {d.DogName} is a  " +
                    $"{d.DogBreed} and is very {d.DogSize}. His owner is called {d.Owner.OwnerName}"));

                owners.ForEach(o => Console.WriteLine($"{o.OwnerId,-10}{o.OwnerName}"));
            }
        }
    }
}