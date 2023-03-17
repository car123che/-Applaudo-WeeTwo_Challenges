namespace Challenge
{
    public class Person
    {
        private long _Dpi { get; set; }
        private string _Name { get; set; }
        private int _Age { get; set; }

        public Person()
        {
            _Name = "";
        }

        public Person(long dpi, string name, int age)
        {
            _Dpi = dpi;
            _Name = name;
            _Age = age;
        }


    }
}