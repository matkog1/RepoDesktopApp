using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class User
    {
        private const char Del = '#';
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString() => $"{FirstName} {LastName}";
        public string FormatForFileLine() => $"{Id}{Del}{FirstName}{Del}{LastName}";
        public static User ParseFromFileLine(string line)
        {
            string[] details = line.Split(Del);
            return new User
            {
                Id = int.Parse(details[0]),
                FirstName = details[1],
                LastName = details[2]
            };
        }
    }
}
