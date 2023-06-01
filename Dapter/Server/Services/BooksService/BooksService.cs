using Dapter.Shared;
using Dapter.Shared.Entities.DTOs;
using Dapter.Shared.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dapter.Server.Services.BookService
{
    public class BooksService : IBooksService
    {
        private readonly DapterContext _dataContext;
        public BooksService(DapterContext dataContext)
        {
            _dataContext = dataContext;
        }
        /// <summary>
        /// Метод возвращает список всех книг.
        /// The method returns a list of all books.
        /// </summary>
        /// <returns></returns>
        public async Task<ServiceResponse<List<Book>>> GetAllBooksAsync()
        {
            var books = await _dataContext.Books.ToListAsync();
            if(books is not null)
            {
                return new ServiceResponse<List<Book>>
                {
                    Data = books,
                    Success = true
                };
            }
            else
            {
                return new ServiceResponse<List<Book>>
                {
                    Data = null,
                    Success = false,
                    Message = "Список книг пуст =("
                };  
            }
        }
    }
}
