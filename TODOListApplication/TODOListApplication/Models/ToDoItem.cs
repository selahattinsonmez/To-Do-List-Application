using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODOListApplication.Models
{
    public class ToDoItem
    {
        public long itemId;
        public long listId; 
        public String itemName;
        public String itemDescription;
        public DateTime itemDeadline;
        public Boolean status;
        public Boolean dependency;
        public Boolean expired;

    }
}
