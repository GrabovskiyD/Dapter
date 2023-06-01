using Dapter.Server.Services.BookService;
using Dapter.Shared.Entities.DTOs;
using Dapter.Shared.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dapter.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBooksService _bookService;
        public BookController(IBooksService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Book>>>> GetAllBooksAsync()
        {
            var response = await _bookService.GetAllBooksAsync();
            return Ok(response);
        } 
    }
}
