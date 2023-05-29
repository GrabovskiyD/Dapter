namespace Dapter.Shared.Entities.Models
{
    public abstract class ItemBaseModel
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; } = string.Empty;
        public virtual string? Description { get; protected set;}
    }
}
