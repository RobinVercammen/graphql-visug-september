using System.Net.Http;
using Newtonsoft.Json;

namespace GraphQL.StarWars
{
    public class StarWarsHttpClient : HttpClient
    {
    }

	public class Planet
	{
		[JsonProperty("edited")]
		public string Edited { get; set; }

		[JsonProperty("orbital_period")]
		public string OrbitalPeriod { get; set; }

		[JsonProperty("created")]
		public string Created { get; set; }

		[JsonProperty("climate")]
		public string Climate { get; set; }

		[JsonProperty("diameter")]
		public string Diameter { get; set; }

		[JsonProperty("gravity")]
		public string Gravity { get; set; }

		[JsonProperty("films")]
		public string[] Films { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("residents")]
		public string[] Residents { get; set; }

		[JsonProperty("surface_water")]
		public string SurfaceWater { get; set; }

		[JsonProperty("population")]
		public string Population { get; set; }

		[JsonProperty("rotation_period")]
		public string RotationPeriod { get; set; }

		[JsonProperty("terrain")]
		public string Terrain { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	public class People
	{
		[JsonProperty("height")]
		public string Height { get; set; }

		[JsonProperty("eye_color")]
		public string EyeColor { get; set; }

		[JsonProperty("created")]
		public string Created { get; set; }

		[JsonProperty("birth_year")]
		public string BirthYear { get; set; }

		[JsonProperty("edited")]
		public string Edited { get; set; }

		[JsonProperty("gender")]
		public string Gender { get; set; }

		[JsonProperty("films")]
		public string[] Films { get; set; }

		[JsonProperty("hair_color")]
		public string HairColor { get; set; }

		[JsonProperty("skin_color")]
		public string SkinColor { get; set; }

		[JsonProperty("mass")]
		public string Mass { get; set; }

		[JsonProperty("homeworld")]
		public string Homeworld { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("starships")]
		public string[] Starships { get; set; }

		[JsonProperty("species")]
		public string[] Species { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("vehicles")]
		public string[] Vehicles { get; set; }
	}
}
