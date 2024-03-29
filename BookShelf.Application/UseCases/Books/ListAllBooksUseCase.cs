using BookShelf.Communication.Enums;
using BookShelf.Communication.Responses.Books;

namespace BookShelf.Application.UseCases.Books;

public class ListAllBooksUseCase
{
    public ListAllBooksResponse Execute()
    {
        return new ListAllBooksResponse
        {
            Books =
            {
                new BooksResponse
                {
                    Id = 1,
                    Title = "Any Title",
                    Author = "Any Author",
                    Gender = BookGender.Adventure,
                    Price = 10,
                    StockCount = 1
                },
                new BooksResponse
                {
                    Id = 2,
                    Title = "Any Title 2",
                    Author = "Any Author 2",
                    Gender = BookGender.Fiction,
                    Price = 20,
                    StockCount = 1
                },
                new BooksResponse
                {
                    Id = 2,
                    Title = "Any Title 3",
                    Author = "Any Author 3",
                    Gender = BookGender.Suspense,
                    Price = 15,
                    StockCount = 1
                }
            }
        };
    }
}