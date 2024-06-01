using TestApi.Core.Enum;

namespace TestApi.Core.DTOs
{
    public class ToDoListDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ToDoEnum Status { get; set; }
        public DateTime CreateAt => DateTime.Now;
    }
}
