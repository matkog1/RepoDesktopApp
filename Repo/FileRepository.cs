using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    class FileRepository : IRepository
    {
        private const string ITEMS_FILE_NAME = @"C:\Users\programer10\Desktop\data\items.txt";
        private const string USERS_FILE_NAME = @"C:\Users\programer10\Desktop\data\users.txt";

        public FileRepository()
        {
            CreateFilesIfNonExistent();
        }

        private void CreateFilesIfNonExistent()
        {
            //if file ne postoji
            // create file
            if (!File.Exists(ITEMS_FILE_NAME))
            {
                File.Create(ITEMS_FILE_NAME).Close();
            }
            if (!File.Exists(USERS_FILE_NAME))
            {
                File.Create(USERS_FILE_NAME).Close();
            }
        }

        public void AddItem(TodoItem item)
        {
            AddUser(item.User);
            //additem
            ISet<TodoItem> items = GetItems();
            items.Add(item);
            File.WriteAllLines(ITEMS_FILE_NAME, items.Select(i => i.FormatForFileLine()));
        }

        private void AddUser(User user)
        {
            ISet<User> users = GetUsers();
            users.Add(user);
            File.WriteAllLines(USERS_FILE_NAME, users.Select(u => u.FormatForFileLine()));
        }

        public ISet<TodoItem> GetItems()
        {
            ISet<TodoItem> items = new HashSet<TodoItem>();
            string[] lines = File.ReadAllLines(ITEMS_FILE_NAME);
            lines.ToList().ForEach(line => items.Add(TodoItem.ParseFromFileLine(line)));
            return items;
        }

        public User GetUser(int id) => GetUsers().FirstOrDefault(u => u.Id == id);

        public ISet<User> GetUsers()
        {
            ISet<User> users = new HashSet<User>();
            string[] lines = File.ReadAllLines(USERS_FILE_NAME);
            lines.ToList().ForEach(line => users.Add(User.ParseFromFileLine(line)));
            return users;
        }
    }
}
