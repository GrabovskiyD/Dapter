using Dapter.Shared.Entities.Utils;

namespace Dapter.Shared.Entities.Models
{
    public class Movie : ItemBaseModel
    {
        public string? Director { get; set; }
        public List<String>? Actors { get; set; }
        public string? Genre { get; set; }
        public string? ReleaseYear { get; set; }
        public override Category Category { get; set; } = Category.Movie;
    }
}
