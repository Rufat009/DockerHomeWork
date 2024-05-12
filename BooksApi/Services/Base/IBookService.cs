

using BooksApi.Models;

namespace BooksApi.Services.Base;

public interface IBookService
{
    Task<Book> GetByIdAsync(int? Id);
}
