using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleExamTaskList
{
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(ToDoItem toDoItem)
        {
            ToDoItem = toDoItem;
        }

        public ToDoItem ToDoItem {  get; set; }


    }

}
