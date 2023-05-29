namespace Dapter.Shared.Entities.Models
{
    public abstract class ItemBaseModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; } = string.Empty;
        public virtual string? Description { get; set;}

        //TODO: Добавить к моделям XML комментарии.
    }
}
