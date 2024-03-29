using System;

namespace ToDoList.Model
{
    public class ToDoItems
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DoneDate { get; set; }
    }
}