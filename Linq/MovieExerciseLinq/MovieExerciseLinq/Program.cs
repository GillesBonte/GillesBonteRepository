using System.Dynamic;

namespace MovieExerciseLinq
{
    internal class Program
    {
        static ListOfMovies _movies = new ListOfMovies();
        static void Main(string[] args)
        {
            
            IEnumerable<string> result = new List<string>();

            //result = GetAllTwentyTenMovies();
            //result = RatingBetweenFourAndSix();
            //result = StevenSpielbergMovies();
            //result = FilmsPerDirector();
            //result = FilmsPerProducer();
            result = AverageRatingPerYear();

            ShowResult(result);
            Console.ReadLine();
        }

        static IEnumerable<string> GetAllTwentyTenMovies()
        {
            return from Movie in _movies
                   where Movie.ReleaseDate.Year == 2010
                   select $"{Movie.Name}\t{Movie.ReleaseDate.Date.Month}/{Movie.ReleaseDate.Date.Year}";
        }

        static IEnumerable<string> RatingBetweenFourAndSix()
        {
            return from Movie in _movies
                   where Movie.Rating >= 4 && Movie.Rating <= 6
                   select $"{Movie.Name}\t{Movie.Rating}";
        }

        static IEnumerable<string> StevenSpielbergMovies()
        {
            return from Movie in _movies
                   where Movie.Director == "Steven Spielberg"
                   select $"{Movie.Name}\t{Movie.Director}";
        }

        static IEnumerable<string> FilmsPerDirector()
        {
            return from Movie in _movies
                   group Movie by Movie.Director into MoviesPerDirector
                   select $"{MoviesPerDirector.Key}\t{MoviesPerDirector.Count()}".ToString();
        }

        static IEnumerable<string> FilmsPerProducer()
        {
            return from Movie in _movies
                   group Movie by Movie.Producer into MoviesPerProducer
                   select $"{MoviesPerProducer.Key}\t{MoviesPerProducer.Count()}".ToString();
        }

        static IEnumerable<string> AverageRatingPerYear()
        {
            return from Movie in _movies
                   group Movie by Movie.ReleaseDate.Year into MoviePerYear
                   //select $"{MoviePerYear.Key}\t{MoviePerYear.Count()}";
            select
            
                $"Year = {MoviePerYear.Key}\tAverageRating = {MoviePerYear.Average(movie => movie.Rating)}"
            ;
        }

        static void ShowResult(IEnumerable<string> result)
        {
            foreach (string item in result) 
            {
                Console.WriteLine(item);
            }
        }

    }
}