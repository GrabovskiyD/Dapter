using Dapter.Shared.Entities.Utils;

namespace Dapter.Shared.Entities.Models
{
    public abstract class ItemBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set;}
        public string? ImageBase64 { get; set; }
        public virtual Category Category { get; set; }

        //TODO: Добавить к моделям XML комментарии.
    }
}
