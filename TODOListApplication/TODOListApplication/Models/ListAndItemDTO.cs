using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODOListApplication.Models
{
    public class ListAndItemDTO
    {
        public long userId { get; set; }
        public String listName { get; set; }
        public long listId { get; set; }
        public List<itemAndDependencyDTO> toDoItems;
    }
}
