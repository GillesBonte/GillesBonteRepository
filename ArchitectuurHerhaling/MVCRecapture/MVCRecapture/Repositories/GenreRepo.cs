using MVCRecapture.Interfaces;
using MVCRecapture.Models;
using System.Xml.Linq;

namespace MVCRecapture.Repositories
{
    public class GenreRepo : IRepository<Genre>
    {
        public GenreRepo()
        {
            if (Globals._genre is null)
            {
                Globals._genre = new List<Genre>();
                Globals._genre.Add(new Genre() { Name = "Adventure", Type = "Dungeons", Subgenre = "Crawler" });
                Globals._genre.Add(new Genre() { Name = "Action", Type = "Shooter", Subgenre = "Multiplayer" });
                Globals._genre.Add(new Genre() { Name = "RPG", Type = "Japan", Subgenre = "Manga" });
                Globals._genre.Add(new Genre() { Name = "MMO", Type = "Online", Subgenre = "Multiplayer" });
                Globals._genre.Add(new Genre() { Name = "CarRacing", Type = "Racing", Subgenre = "Arcade" });
                Globals._genre.Add(new Genre() { Name = "MotoRacing", Type = "Racing", Subgenre = "Simulator" });
            }
        }

        public IEnumerable<Genre> GetAll()
        {
            return Globals._genre;
        }

        public Genre GetByName(string name)
        {
            return Globals._genre.Find(genre => genre.Name == name);
        }

        public void Delete(string name)
        {
            Genre toDelete = GetByName(name);
            if (toDelete != null)
            {
                Globals._genre.Remove(toDelete);
            }
        }

        public void Update(Genre genre)
        {
            Genre toUpdate = GetByName(genre.Name);
            if (toUpdate != null)
            {
                Globals._genre.Remove(toUpdate);
                Globals._genre.Add(genre);
            }
        }

        public void Add(Genre entity)
        {
            Globals._genre.Add(entity);
        }
    }
}
