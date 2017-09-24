using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.StarWars.Types;
using Newtonsoft.Json;

namespace GraphQL.StarWars
{
    public class StarWarsData
    {
        private readonly List<Human> _humans = new List<Human>();
        private readonly List<Droid> _droids = new List<Droid>();
        private readonly StarWarsHttpClient _httpClient;

        public StarWarsData(StarWarsHttpClient httpClient)
        {
            _httpClient = httpClient;
            _humans.Add(new Human
            {
                Id = "1",
                Name = "Luke",
                Friends = new[] { "3", "4" },
                AppearsIn = new[] { 4, 5, 6 },
                HomePlanet = "Tatooine"
            });
            _humans.Add(new Human
            {
                Id = "2",
                Name = "Vader",
                AppearsIn = new[] { 4, 5, 6 },
                HomePlanet = "Tatooine"
            });

            _droids.Add(new Droid
            {
                Id = "3",
                Name = "R2-D2",
                Friends = new[] { "1", "4" },
                AppearsIn = new[] { 4, 5, 6 },
                PrimaryFunction = "Astromech"
            });
            _droids.Add(new Droid
            {
                Id = "4",
                Name = "C-3PO",
                AppearsIn = new[] { 4, 5, 6 },
                PrimaryFunction = "Protocol"
            });
        }

        public IEnumerable<StarWarsCharacter> GetFriends(StarWarsCharacter character)
        {
            if (character == null)
            {
                return null;
            }

            var friends = new List<StarWarsCharacter>();
            var lookup = character.Friends;
            if (lookup != null)
            {
                _humans.Where(h => lookup.Contains(h.Id)).Apply(friends.Add);
                _droids.Where(d => lookup.Contains(d.Id)).Apply(friends.Add);
            }
            return friends;
        }

        public async Task<Human> GetHumanByIdAsync(string id)
        {
            var result = await _httpClient.GetAsync($"https://swapi.co/api/people/{id}");
            var a = await result.Content.ReadAsStringAsync();
            var people = JsonConvert.DeserializeObject<People>(a);
            var homeWorldResult = await _httpClient.GetAsync(people.Homeworld);
            var b = await homeWorldResult.Content.ReadAsStringAsync();
            var homeWorld = JsonConvert.DeserializeObject<Planet>(b);

            var human = new Human
            {
                Id = id,
                HomePlanet = homeWorld.Name,
                Name = people.Name
            };
            return human;
        }

        public Task<Droid> GetDroidByIdAsync(string id)
        {
            return Task.FromResult(_droids.FirstOrDefault(h => h.Id == id));
        }

        public Human AddHuman(Human human)
        {
            human.Id = Guid.NewGuid().ToString();
            _humans.Add(human);
            return human;
        }
    }


}
