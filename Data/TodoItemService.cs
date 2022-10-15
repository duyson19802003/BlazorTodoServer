using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BlazorTodoServer.Data
{
    public class TodoItemService
    {
        private static List<TodoItem> _data = new List<TodoItem>() {
            new TodoItem{ Title = "Meet Donald Trump"},
            new TodoItem{ Title = "Lunch with Barack Obama"},
            new TodoItem{ Title = "Go fishing with Bill Gates"},
            new TodoItem{ Title = "Walking with Putin"},
        };
        private readonly string _file = "Data\\todo.json";
        public List<TodoItem> GetData()
        {
            if (File.Exists(_file))
            {
                using var file = File.OpenText(_file);
                var serializer = new JsonSerializer();
                _data = serializer.Deserialize(file, typeof(List<TodoItem>)) as List<TodoItem>;
            }
            return _data;
        }
        public void SaveChanges()
        {
            using var file = File.CreateText(_file);
            var serializer = new JsonSerializer();
            serializer.Serialize(file, _data);
        }
    }
}