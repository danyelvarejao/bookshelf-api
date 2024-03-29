using BookShelf.Communication.Requests.Books;
using BookShelf.Communication.Responses.Books;

namespace BookShelf.Application.UseCases.Books;

public class CreateBookUseCase
{
    public CreatedBookResponse Execute(CreateBookRequest request)
    {
        return new CreatedBookResponse
        {
            Id = 1,
            Title = request.Title,
            Author = request.Author,
            Gender = request.Gender,
            Price = request.Price
        };
    }
}