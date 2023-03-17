namespace Challenge
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }

        public Book()
        {
            Title = "";
            Description = "";
        }

        public Book(int id, string title, string description, double price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }

}