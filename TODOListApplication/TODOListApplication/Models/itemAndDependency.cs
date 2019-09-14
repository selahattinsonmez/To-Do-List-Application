using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODOListApplication.Models
{
    public class itemAndDependency
    {
        public long itemId;
        public long listId;
        public String itemName;
        public String dependencyName;
        public String itemDescription;
        public DateTime itemDeadline;
        public Boolean status;
        public Boolean dependency;
        public Boolean expired;
    }
}
