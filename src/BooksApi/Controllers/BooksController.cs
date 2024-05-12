
using BooksApi.Services.Base;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers;

[ApiController]
[Route("/api/[controller]/[action]")]
public class BooksController : ControllerBase
{
    private readonly IBookService mongoBooksService;

    public BooksController(IBookService mongoBooksService)
    {
        this.mongoBooksService = mongoBooksService;
    }
    
    public async Task<IActionResult> GetBookAsync(int? id)
    {
        var mongoBook = await mongoBooksService.GetByIdAsync(id);

        return base.Ok(mongoBook);
    }
}
