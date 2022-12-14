using Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    internal class Program
    {
        static IRepository repository = RepositoryFactory.GetRepository();
        static void Main(string[] args)
        {
            FillItems();
            ReadItems();
            Console.WriteLine();
            ReadUsers();
            Console.WriteLine();
            ReadSingleUser();
        }

        private static void FillItems()
        {
            repository.AddItem(
                new TodoItem
                {
                    Date = DateTime.Now.AddDays(-2),
                    Description = "First",
                    Id = 1,
                    User = new User
                    {
                        Id = 1,
                        FirstName = "Lazo",
                        LastName = "Goluza"
                    }
                });
            repository.AddItem(
                new TodoItem
                {
                    Date = DateTime.Now,
                    Description = "Second",
                    Id = 2,
                    User = new User
                    {
                        Id = 2,
                        FirstName = "Militza Krmpotich",
                        LastName = "Lepa"
                    }
                });
            repository.AddItem(
                new TodoItem
                {
                    Date = DateTime.Now.AddDays(-1),
                    Description = "Third",
                    Id = 3,
                    User = new User
                    {
                        Id = 1,
                        FirstName = "Lazo",
                        LastName = "Goluza"
                    }
                });

            repository.GetUsers().Clear();
            repository.GetItems().Clear();
        }

        private static void ReadItems() => repository.GetItems().ToList().ForEach(Console.WriteLine);

        private static void ReadUsers() => repository.GetUsers().ToList().ForEach(Console.WriteLine);

        private static void ReadSingleUser() => Console.WriteLine(repository.GetUser(1));
    }
}
