using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    abstract class Item
    {
        public string Title { get; set;  }
        public abstract void DisplayInfo();
    }
    
    
}
