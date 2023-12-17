using ClassLibrary.Constant;
using ClassLibrary.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public class ApiRepo : IRepo
    {
        private string TEAM_PATH;
        private string MATCHES_PATH;

        public ApiRepo(string? championship)
        {
            TEAM_PATH = championship == "0" ? ApiEndpoint.MEN : ApiEndpoint.WOMEN;
            MATCHES_PATH = championship == "0" ? ApiEndpoint.MEN_MATCHES : ApiEndpoint.WOMEN_MATCHES;
        }
        public List<Match> GetAllMatches()
        {
            RestClient client = new(MATCHES_PATH);
            RestResponse result = client.Execute<List<Match>>(new RestRequest());
            return JsonConvert.DeserializeObject<List<Match>>(result.Content);
        }
        public List<StartingEleven> GetAllPlayersCountry(string? countryCode)
        {
            List<StartingEleven> players = new();
            Match match = GetMatchesCountry(countryCode).First();
            players
                .AddRange(match.AwayTeam.Code == countryCode
                ? match.AwayTeamStatistics.StartingEleven
                : match.HomeTeamStatistics.StartingEleven);
            players
                .AddRange(match.AwayTeam.Code == countryCode
                ? match.AwayTeamStatistics.Substitutes
                : match.HomeTeamStatistics.Substitutes);
            return players;
        }
        public List<Match> GetMatchesCountry(string? countryCode)
        {
            List<Match> matches = new();
            matches.AddRange(GetAllMatches().Where(m => m.AwayTeam.Code == countryCode || m.HomeTeam.Code == countryCode));
            return matches;
        }
        public Team GetTeam(string? countryCode) => GetTeams().FirstOrDefault(t => t.FifaCode == countryCode);
        public List<Team> GetTeams()
        {
            RestClient client = new(TEAM_PATH);
            RestResponse result = client.Execute<List<Team>>(new RestRequest());
            return JsonConvert.DeserializeObject<List<Team>>(result.Content);
        }    
    }
}
