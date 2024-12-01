using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoListApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
