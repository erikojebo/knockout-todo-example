using System;

namespace KnockoutTodoExample.Models
{
    public class TodoItem
    {
        public TodoItem()
        {
            Id = Guid.NewGuid();
        }

        public TodoItem(string description) : this()
        {
            Description = description;
        }

        public string Description { get; set; }
        public bool IsDone { get; set; }
        public Guid Id { get; set; }
    }
}