namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Book, int> repository = new Repository<Book, int>();
            repository = ChallengesTests.AddBooks();

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
           
            //Validator
            Console.WriteLine("\n---- VALITOR TESTS --------- ");
            Validator validator = ChallengesTests.ValidatorTest();
            Console.WriteLine("Validator Has Erros?: " + validator.HasErrors());
            Console.WriteLine("Erros Formated: {0}", validator.GetErrorMessages());


            //Repository Get all Overload
            Console.WriteLine("\n------- Getting Filtered List --------");
            List<Book> filteredBooks = new List<Book>();
            filteredBooks = repository.GetAll(b => b.Price > 15);
            foreach (var book in filteredBooks)
            {
                Console.WriteLine(book.toString());
            }
        }

    }

}