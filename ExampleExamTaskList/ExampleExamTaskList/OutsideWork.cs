using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleExamTaskList
{
    public class OutsideWork : ToDoItem
    {
        public override string ToString()
        {
            return $"{this.Name} - {this.Executer}";
        }

    }

}
