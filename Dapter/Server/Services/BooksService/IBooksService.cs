using Dapter.Shared.Entities.DTOs;
using Dapter.Shared.Entities.Models;

namespace Dapter.Server.Services.BookService
{
    public interface IBooksService
    {
        public Task<ServiceResponse<List<Book>>> GetAllBooksAsync();
    }
}
