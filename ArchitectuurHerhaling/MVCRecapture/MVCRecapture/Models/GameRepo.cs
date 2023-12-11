namespace MVCRecapture.Models
{
    public class GameRepo
    {
        public GameRepo()
        {
            if (Globals._games is null)
            {
            Globals._games = new List<Game>();
            Globals._games.Add(new Game() { Id = 1, Name = "GTAV", Aqcuired = false, ReleaseDate = DateOnly.FromDateTime(DateTime.Now) });
            Globals._games.Add(new Game() { Id = 2, Name = "Red Dead Redemption 2", Aqcuired = true, ReleaseDate = DateOnly.FromDateTime(DateTime.Now) });
            Globals._games.Add(new Game() { Id = 3, Name = "Warhammer Online", Aqcuired = true, ReleaseDate = DateOnly.FromDateTime(DateTime.Now) });
            Globals._games.Add(new Game() { Id = 4, Name = "Hearthstone", Aqcuired = false, ReleaseDate = DateOnly.FromDateTime(DateTime.Now) });
            }
        }

        public List<Game> GetAll()
        {
            return Globals._games;
        }

        public Game GetById(int id)
        {
            return Globals._games.Find(game => game.Id == id);
        }
        
        public void Delete(int id)
        {
            Game toDelete = GetById(id);
            if (toDelete != null) 
            {
                Globals._games.Remove(toDelete);
            }
        }

        public void Update (Game game)
        {
            Game toUpdate = GetById(game.Id);
            if (toUpdate != null) 
            {
                Globals._games.Remove(toUpdate);
                Globals._games.Add(game);
            }
        }

    }
}
