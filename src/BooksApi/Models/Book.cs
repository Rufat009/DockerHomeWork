using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Models;

public class Book
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public int? Pages { get; set; }
    public string[]? Tags { get; set; }
}
