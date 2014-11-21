using System.Collections.Generic;
using ASP.NET_5_Starter_Web_Application.Models;

namespace ASP.NET_5_Starter_Web_Application.Services
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> AllItems { get; }
        void Add(TodoItem item);
        TodoItem GetById(int id);
        bool TryDelete(int id);
    }
}
