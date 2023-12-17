using ClassLibrary.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public class FileRepo
    {
        private const string DEL = ":";
        private const string CONFIG_PATH = @"../../../../Files/config.txt";
        private const string FAVS_PATH = @"../../../../Files/favourites.txt";
        private const string SAVED_TEAM_PATH = @"../../../../Files/team.txt";       

        public static void SaveConfig(string preferences) => File.WriteAllText(CONFIG_PATH, preferences);

        public static bool HasConfig()
        {
            try
            {
                string[] temp = File.ReadAllLines(CONFIG_PATH);
                return temp.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Dictionary<string, string> GetConfig()
        {
            Dictionary<string, string> result = new();
            string[] lines = File.ReadAllLines(CONFIG_PATH);
            foreach (string line in lines)
            {
                string[] details = line.Split(DEL);
                result.Add(details[0], details[1]);
            }
            return result;
        }      
        
        public static List<StartingEleven> GetFavourites()
        {
            List<StartingEleven> favouritePlayers = new();
            if (HasFavourites())
            {
                string[] lines = File.ReadAllLines(FAVS_PATH);
                foreach (string line in lines)
                {
                    string[] details = line.Split(DEL);
                    favouritePlayers.Add(new StartingEleven
                    {
                        Name = details[0],
                        Position = details[1],
                        ShirtNumber = long.Parse(details[2]),
                        Captain = Convert.ToBoolean(details[3])
                    });
                }
            }
            return favouritePlayers;
        }

        public static bool HasFavourites()
        {
            try
            {
                File.ReadAllLines(FAVS_PATH);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static void SaveFavourites(List<StartingEleven> favouritePlayers)
        {
            StringBuilder sb = new();
            favouritePlayers.ForEach(p => sb.AppendLine(p.Name + DEL + p.Position + DEL + p.ShirtNumber + DEL + p.Captain));
            File.WriteAllText(FAVS_PATH, sb.ToString());
        }

        public static bool HasSavedTeam()
        {
            try
            {
                File.ReadAllLines(SAVED_TEAM_PATH);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static string GetSavedTeam()
        {
            if (HasSavedTeam())
            {
                return File.ReadAllText(SAVED_TEAM_PATH);
            }
            return string.Empty;
        }

        public static void SaveTeam(string? teamCode) => File.WriteAllText(SAVED_TEAM_PATH, teamCode);
    }
}
