using MVCRecapture.Interfaces;
using MVCRecapture.Models;
using Newtonsoft.Json;

namespace MVCRecapture.Repositories
{
    public class GameFileRepository : IRepository<Game>
    {
        const string fileLocation = @"c:\temp\file_db\games.json";

        public IEnumerable<Game> GetAll()
        {
            if (File.Exists(fileLocation))
            {
                string text = File.ReadAllText(fileLocation);
                List<Game> list = JsonConvert.DeserializeObject<List<Game>>(text);
                return list;
            }
            else
            {
                return new List<Game>();
            }

        }

        public void Add(Game game)
        {
            List<Game> games = GetAll().ToList();
            games.Add(game);
            string text = JsonConvert.SerializeObject(games);
            File.WriteAllText(fileLocation, text );

        }
    }
}
