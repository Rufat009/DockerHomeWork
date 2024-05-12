
using BooksApi.Models;
using BooksApi.Repositories.Base;
using BooksApi.Services.Base;

namespace BooksApi.Services;

public class BookService : IBookService
{
    private readonly IBookRepository mongoBookRepository;

    public BookService(IBookRepository mongoBookRepository)
    {
        this.mongoBookRepository = mongoBookRepository;
    }

    public async Task<Book> GetByIdAsync(int? id)
    {
        var mongoBook = await this.mongoBookRepository.GetBookByIdAsync((int)id);

        return mongoBook;
    }
}
