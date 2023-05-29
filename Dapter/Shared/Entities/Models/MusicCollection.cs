namespace Dapter.Shared.Entities.Models
{
    public class MusicCollection : ItemBaseModel
    {
        public string? Type { get; set; }
        public List<Song>? Songs { get; set; }
    }
}
