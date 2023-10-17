using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieExerciseLinq
{
    public class ListOfMovies : List<Movie>
    {
        public ListOfMovies() 
        { 

            this.Add(new Movie()
            {
                Name = "Inception",
                Rating = 6,
                Producer = "Christopher Nolan",
                Director = "Christopher Nolan",
                ReleaseDate = DateTime.ParseExact("21/07/2010","dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            });

            this.Add(new Movie()
            {
                Name = "Alice in Wonderland",
                Rating = 7,
                Producer = "Joe Roth",
                Director = "Tim Burton",
                ReleaseDate = DateTime.ParseExact("05/03/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            });

            this.Add(new Movie()
            {
                Name = "Jaws",
                Rating = 5,
                Producer = "Richard D. Zanuck",
                Director = "Steven Spielberg",
                ReleaseDate = DateTime.ParseExact("20/06/1975", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            });

            this.Add(new Movie()
            {
                Name = "E.T.",
                Rating = 5,
                Producer = "Steven Spielberg",
                Director = "Steven Spielberg",
                ReleaseDate = DateTime.ParseExact("26/05/1982", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            });

            this.Add(new Movie()
            {
                Name = "Super 8",
                Rating = 4,
                Producer = "J.J. Abrams",
                Director = "J.J. Abrams",
                ReleaseDate = DateTime.ParseExact("10/06/2011", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            });

            this.Add(new Movie()
            {
                Name = "The book of Eli",
                Rating = 6,
                Producer = "J.J. Abrams",
                Director = "Joel Silver",
                ReleaseDate = DateTime.ParseExact("15/01/2010", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            });
        }
    }
}
