namespace BookShelf.Communication.Responses.Books;

public class ListAllBooksResponse
{
    public List<BooksResponse> Books { get; set; } = [];
}