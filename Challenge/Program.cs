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


            //Validator
            Console.WriteLine("---- VALITOR TESTS --------- ");
            Validator validator = ValidatorTest();
            Console.WriteLine("Validator Has Erros?: " + validator.HasErrors());


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

        public static Validator ValidatorTest()
        {
            Validator validator = new Validator((data) => data.Length >= 5 && data.Length <= 10);
            string dataOne = "cinco";
            string dataTwo = "abc";
            string dataThree = "";
            string dataLengthErrorMessage = "Data Length should be greater or equal than 5";

            if (validator.IsValid(dataOne))
            {
                Console.WriteLine("Data: '{0}'.  Is valid", dataOne);
            }
            else
            {
                Console.WriteLine("Data: '{0}'.  Is Invalid", dataOne);
            }

            if (validator.IsValid(dataTwo, dataLengthErrorMessage))
            {
                Console.WriteLine("Data: '{0}'.  Is valid", dataTwo);
            }
            else
            {
                Console.WriteLine("Data: '{0}'.  Is Invalid", dataTwo);
            }


            if (validator.IsValid(dataThree, dataLengthErrorMessage))
            {
                Console.WriteLine("Data: '{0}'.  Is valid", dataThree);
            }
            else
            {
                Console.WriteLine("Data: '{0}'.  Is Invalid", dataThree);
            }

            return validator;

        }


    }


}