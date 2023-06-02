using Dapter.Shared.Entities.DTOs;
using Dapter.Shared.Entities.Models;

namespace Dapter.Server.Services.BookService
{
    public interface IBooksService
    {
        #region GET методы
        public Task<ServiceResponse<List<Book>>> GetAllBooksAsync();
        #endregion

        #region POST методы
        public Task<ServiceResponse<List<Book>>> AddNewBookAsync(Book book);
        #endregion
    }
}
