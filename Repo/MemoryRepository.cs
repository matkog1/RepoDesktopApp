using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    class MemoryRepository : IRepository
    {
        private ISet<TodoItem> items = new HashSet<TodoItem>();
        private ISet<User> users = new HashSet<User>();
        public void AddItem(TodoItem item)
        {
            users.Add(item.User);
            items.Add(item);
        }

        public ISet<TodoItem> GetItems() => new HashSet<TodoItem>(items); // DANGER!!!
        public User GetUser(int id) => users.FirstOrDefault(u => u.Id == id);   

        public ISet<User> GetUsers() => new HashSet<User>(users);
    }
}
