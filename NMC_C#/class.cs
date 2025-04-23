public class Book
{
    // Changable Variables (Info to Describe Book) // 
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PageCount { get; set; }
    public double Rating { get; set; }

    // Default Values // 
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Genre = "Unknown";
        PageCount = 0;
        Rating = 0.0;
    }

    // Input Values for Book // 
    public Book(string title, string author, string genre, int pageCount, double rating)
    {
        Title = title;
        Author = author;
        Genre = genre;
        PageCount = pageCount;
        Rating = rating;
    }

    // Book Summary // 
    public string GetBookSummary()
    {
        return $"{Title} by {Author} ({Genre}, {PageCount} pages, Rating: {Rating}/5)";
    }
}
