using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleExamTaskList
{
    public abstract class ToDoItem
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Executer {  get; set; }
        public string? Location { get; set; }
        public DateTime? DateExecuted { get; set; }

    }



}
