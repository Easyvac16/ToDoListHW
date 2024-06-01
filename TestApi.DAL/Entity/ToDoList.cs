using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Core.Enum;

namespace TestApi.DAL.Entity
{
    public class ToDoList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ToDoEnum Status { get; set; }
        public DateTime CreateAt => DateTime.Now;
    }
}
