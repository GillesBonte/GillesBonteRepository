namespace BookExerciseLinq
{
    internal class Program
    {
        static List<Book> _books = new List<Book>();
        static List<Writer> _writers = new List<Writer>();
        static List<Publisher> _publisher = new List<Publisher>();
        static void Main(string[] args)
        {
            CreateData();
            IEnumerable<string> result;

            //result = GetData1();
            //result = GetData2();
            result = GetData3();

            ShowResult(result);
            Console.ReadLine();
        }
        static IEnumerable<string> GetData3()
        {
            return from book in _books
                   join writer in _writers on book.WriterID equals writer.ID
                   join publisher in _publisher on writer.PublisherID equals publisher.ID
                   select $"Book: {book.Name}\nWriter: {writer.Gender}\nPublisherCountry: {publisher.Country}\n";
        }
        static IEnumerable<string> GetData1()
        {
            return from book in _books
                   join writer in _writers on book.WriterID equals writer.ID
                   select $"Book: {book.Name}\nWriter: {writer.FirstName}";
        }
        static IEnumerable<string> GetData2()
        {
            return from writer in _writers
                   join publisher in _publisher on writer.PublisherID equals publisher.ID
                   select $"{writer.FirstName} {writer.LastName} published by {publisher.Name}";
        }
        static void ShowResult(IEnumerable<string> result) 
        {
            foreach (var item in result)                
            {
                Console.WriteLine(item);
            }
        }
        static void CreateData()
        {
            CreateBooks();
            CreateWriters();
            CreatePublishers();
        }
        static void CreatePublishers()
        {
            _publisher.Add(new Publisher()
            {
                ID = 1,
                Name = "Pub11",
                Country = "Belgium"
            });

            _publisher.Add(new Publisher()
            {
                ID = 2,
                Name = "Pub11sher",
                Country = "Belgium"
            });

            _publisher.Add(new Publisher()
            {
                ID = 3,
                Name = "Pub11char",
                Country = "France"
            });

        }
        static void CreateWriters()
        {
            _writers.Add(new Writer()
            {
                ID = 1,
                FirstName = "FN1",
                LastName = "FN2",
                Gender = "man",
                PublisherID = 1,
            });
            _writers.Add(new Writer()
            {
                ID = 2,
                FirstName = "FN3",
                LastName = "FN4",
                Gender = "vrouw",
                PublisherID = 1,
            });
            _writers.Add(new Writer()
            {
                ID = 3,
                FirstName = "FN4",
                LastName = "FN5",
                Gender = "man",
                PublisherID = 1,
            });
            _writers.Add(new Writer()
            {
                ID = 4,
                FirstName = "FN6",
                LastName = "FN7",
                Gender = "vrouw",
                PublisherID = 3,
            });
            _writers.Add(new Writer()
            {
                ID = 5,
                FirstName = "FN8",
                LastName = "FN9",
                Gender = "X",
                PublisherID = 3,
            });
            _writers.Add(new Writer()
            {
                ID = 6,
                FirstName = "FN10",
                LastName = "FN11",
                Gender = "man",
                PublisherID = 2,
            });
        }
        static void CreateBooks()
        {
            _books.Add(new Book()
            {
                ID = 1,
                Name = "Book1",
                PageCount = 155,
                WriterID = 1,
                Score = 5
            });
            _books.Add(new Book()
            {
                ID = 2,
                Name = "Book2",
                PageCount = 155,
                WriterID = 1,
                Score = 5
            });
            _books.Add(new Book()
            {
                ID = 3,
                Name = "Book3",
                PageCount = 155,
                WriterID = 2,
                Score = 5
            });
            _books.Add(new Book()
            {
                ID = 4,
                Name = "Book4",
                PageCount = 155,
                WriterID = 2,
                Score = 5
            });
            _books.Add(new Book()
            {
                ID = 5,
                Name = "Book5",
                PageCount = 155,
                WriterID = 3,
                Score = 5
            });
            _books.Add(new Book()
            {
                ID = 6,
                Name = "Book6",
                PageCount = 155,
                WriterID = 5,
                Score = 5
            });
        }
    }
}