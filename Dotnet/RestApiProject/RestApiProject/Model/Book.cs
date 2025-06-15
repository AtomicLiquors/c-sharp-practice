namespace RestApiProject.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!; // initial null value

        public string Author { get; set; } = null!;    
        
        public int YearPublished { get; set; }  

    }
}
