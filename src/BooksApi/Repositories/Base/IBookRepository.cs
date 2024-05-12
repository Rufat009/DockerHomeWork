using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksApi.Models;

namespace BooksApi.Repositories.Base;

public interface IBookRepository
{
    Task<Book> GetBookByIdAsync(int id);
}
