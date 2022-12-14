using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IRepository
    {
        void AddItem(TodoItem item);
        ISet<TodoItem> GetItems();
        ISet<User> GetUsers();
        User GetUser(int id);
    }
}
