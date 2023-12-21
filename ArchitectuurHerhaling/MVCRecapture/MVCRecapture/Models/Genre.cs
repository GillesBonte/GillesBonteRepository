namespace MVCRecapture.Models
{
    public class Genre
    {
        public string Subgenre { get; set; }
        public string Type { get; set; }

        //Key / Should be ReadOnly
        public string Name { get; set; }
    }

}
