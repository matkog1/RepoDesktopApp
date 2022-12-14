using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class TodoItem
    {
        private const char Del = '|';

        private const string DateFormat = "dd:MM:yyyy";
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TodoItem item &&
                   Id == item.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override string ToString() => $"{Description}, {Date.ToString(DateFormat)}, {User}";
        public string FormatForFileLine() => $"{Id}{Del}{Description}{Del}{Date.ToString(DateFormat)}{Del}" +
            $"{User.FormatForFileLine()}";

        public static TodoItem ParseFromFileLine(string line)
        {
            string[] details = line.Split(Del);
            return new TodoItem
            {
                Id = int.Parse(details[0]),
                Description = details[1],
                Date = DateTime.ParseExact(details[2], DateFormat, null),
                User = User.ParseFromFileLine(details[3])
            };
        }
    }
}
