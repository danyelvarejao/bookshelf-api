using BookShelf.Communication.Enums;

namespace BookShelf.Communication.Responses.Books;

public class BooksResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public BookGender Gender { get; set; }
    public decimal Price { get; set; }
    public int StockCount { get; set; }
}