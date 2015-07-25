using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace toDoList
{
  [Table("toDo")]
    public class ToDo
    {
        [SQLite.PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Goal { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
    }
}
