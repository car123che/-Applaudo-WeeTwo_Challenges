namespace Challenge
{
    public class ChallengesTests
    {

        public static Repository<Book, int> AddBooks()
        {
            string[] BooksNames = new string[5] { ".NET Basics", ".NET Advance", "Python Basics", "JavaScrip Advance", "SQL Server" };
            string[] BooksDescriptions = new string[5] { ".NET Basisc Book", ".NET Advance Book", "Python Basics Bok", "JavaScrip Advance Book", "SQL Server Book" };
            double[] BooksPrices = new double[5] { 15.66, 14, 55, 13.33, 10 };
            Repository<Book, int> repository = new Repository<Book, int>();
            int id = 0;

            for (int i = 0; i < BooksNames.Length; i++)
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

            if (validator.IsValid(dataTwo))
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


        public static void AddPerson()
        {
            // Person Objects ( Person do not implements IEntity )
            Person personOne = new Person(3013216470101, "Carlos Ché", 22);
            Person personTwo = new Person(3013216470102, "Pedro Aguirre", 30);
            Person personThree = new Person(3013216470103, "Pablo Herrera", 25);

            //Repository<Person, long> repository = new Repository<Person, long>();
            //repository.Add(personOne);
        }
    }

}