using BookShelf.Application.UseCases.Books;
using BookShelf.Communication.Requests.Books;
using BookShelf.Communication.Responses;
using BookShelf.Communication.Responses.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookShelf.API.Controllers;

public class BooksController : BookShelfController
{
    [HttpPost]
    [ProducesResponseType(typeof(CreatedBookResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] CreateBookRequest request)
    {
        var useCase = new CreateBookUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ListAllBooksResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ListAll()
    {
        var useCase = new ListAllBooksUseCase();

        var response = useCase.Execute();

        if (response.Books.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status404NotFound)]
    public IActionResult Update([FromRoute] int id, [FromBody] UpdateBookRequest request)
    {
        var useCase = new UpdateBookUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorsResponse), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteBookUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}