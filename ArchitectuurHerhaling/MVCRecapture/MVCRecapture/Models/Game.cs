namespace MVCRecapture.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public bool Aqcuired { get; set; }

        public string Genre { get; set; }
    }
}
