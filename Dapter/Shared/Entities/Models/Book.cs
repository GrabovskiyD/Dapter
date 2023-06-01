using Dapter.Shared.Entities.Utils;

namespace Dapter.Shared.Entities.Models
{
    public class Book : ItemBaseModel
    {
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public override Category Category { get; set; } = Category.Book;
    }
}
