namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Book, int> repository = new Repository<Book, int>();
            repository = AddBooks();



            //Get One Book
            var bookFour = repository.Get(3);
            var bookFive= repository.Get(4);

            //Updating in Book in Repository
            bookFive.Title = "SQL SERVER BASICS";
            repository.Update(bookFive);

            //Deleting a book
            repository.Delete(bookFour);

            //Get all Books
            Console.WriteLine("------- Getting All Books -------");
            List<Book> booksList = repository.GetAll();
            foreach (var book in booksList)
            {
                Console.WriteLine("Book: " + book.Title);
            }
            Console.WriteLine("");
        }

        public static Repository<Book, int>  AddBooks()
        {
            string[] BooksNames = new string[5] { ".NET Basics", ".NET Advance", "Python Basics", "JavaScrip Advance", "SQL Server" };
            string[] BooksDescriptions = new string[5] { ".NET Basisc Book", ".NET Advance Book", "Python Basics Bok", "JavaScrip Advance Book", "SQL Server Book" };
            double[] BooksPrices = new double[5] {15.66, 14, 55, 13.33, 10 };
            Repository<Book, int> repository = new Repository<Book, int>();
            int id = 0;
          
            for(int i = 0; i < BooksNames.Length; i++)
            {
                var book = new Book(id, BooksNames[i], BooksDescriptions[i], BooksPrices[i]);
                repository.Add(book);
                id++;   
            }

            return repository;

        }
    }
}