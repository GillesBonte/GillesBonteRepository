using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleExamTaskList
{
    public class ToDoList<T> : List<T> where T : ToDoItem
    {
    }

}
