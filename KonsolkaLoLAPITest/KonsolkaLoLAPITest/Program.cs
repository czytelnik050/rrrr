using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolkaLoLAPITest
{
	public class Program
	{
		static string apiKey = "89d4cc03-d064-4923-ae15-037e886069a4";
		static string apiVersion = "v1.4";

		static void Main(string[] args)
		{
			var client = new RestClient("https://eune.api.pvp.net");
			var request = new RestRequest("api/lol/{server}/{version}/summoner/by-name/{name}?api_key={key}", Method.GET);
			request.AddUrlSegment("server", "eune");
			request.AddUrlSegment("version", apiVersion);
			request.AddUrlSegment("name", "Iteya");
			request.AddUrlSegment("key", apiKey);
			var queryResult = client.Execute<Dictionary<string, Summoner>>(request);
			Summoner summoner = queryResult.Data.Values.First();
			Console.WriteLine(summoner.id);
			Console.WriteLine(summoner.name);
			Console.WriteLine(summoner.name);
			Console.WriteLine(summoner.profileIconId);
			var date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			date = date.AddMilliseconds(summoner.revisionDate);
			date = date.AddHours(1);
			Console.WriteLine(date);
			Console.WriteLine(summoner.summonerLevel);
		}
	}
}
