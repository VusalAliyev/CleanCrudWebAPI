using Domain.Common;

namespace Domain.Entities
{
    public class TodoItem : BaseAuditableEntity
    {
        public int ListId { get; set; }
        public string? Title { get; set; }
        public string? Note { get; set; }
        public TodoList List { get; set; } = null!;
    }
}
