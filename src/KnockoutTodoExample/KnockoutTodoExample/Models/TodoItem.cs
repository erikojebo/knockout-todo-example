using System;

namespace KnockoutTodoExample.Models
{
    public class TodoItem
    {
        public TodoItem()
        {
            Id = Guid.NewGuid();
            AddedDate = DateTime.Now;
        }

        public TodoItem(string description) : this()
        {
            Description = description;
        }

        public string Description { get; set; }
        public bool IsDone { get; set; }
        public Guid Id { get; set; }
        public DateTime AddedDate { get; set; }
    }
}