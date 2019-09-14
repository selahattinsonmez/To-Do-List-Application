using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODOListApplication.Models
{
    public class itemAndDependencyDTO
    {
        public ToDoItem toDoItem;
        public List<String> dependencies;
    }
}
