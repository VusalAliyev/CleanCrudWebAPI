﻿using Domain.Common;

namespace Domain.Entities
{
    public class TodoList : BaseAuditableEntity
    {
        public string? Title { get; set; }
        public string? Note { get; set; }
        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
