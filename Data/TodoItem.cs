using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodoServer.Data
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool Done { get; set; }
        public string Note { get; set; }
    }
}
