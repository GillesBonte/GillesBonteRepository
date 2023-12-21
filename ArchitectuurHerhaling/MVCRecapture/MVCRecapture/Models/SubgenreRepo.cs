namespace MVCRecapture.Models
{
    public class SubgenreRepo
    {
        public SubgenreRepo()
        {
            if (Globals._subgenre is null)
            {
                Globals._subgenre = new List<Subgenre>();
                Globals._subgenre.Add(new Subgenre() { Name = "Crawler" });
                Globals._subgenre.Add(new Subgenre() { Name = "Multiplayer" });
                Globals._subgenre.Add(new Subgenre() { Name = "Manga" });
                Globals._subgenre.Add(new Subgenre() { Name = "Arcade" });
                Globals._subgenre.Add(new Subgenre() { Name = "Simulator" });
            }
        }

        public List<Subgenre> GetAll()
        {
            return Globals._subgenre;
        }

        public Subgenre GetByName(string name)
        {
            return Globals._subgenre.Find(subgenre => subgenre.Name == name);
        }

        public void Delete(string name)
        {
            Subgenre toDelete = GetByName(name);
            if (toDelete != null)
            {
                Globals._subgenre.Remove(toDelete);
            }
        }

        public void Update(Subgenre genre)
        {
            Subgenre toUpdate = GetByName(genre.Name);
            if (toUpdate != null)
            {
                Globals._subgenre.Remove(toUpdate);
                Globals._subgenre.Add(genre);
            }
        }
    }
}
