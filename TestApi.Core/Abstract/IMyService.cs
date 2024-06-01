using TestApi.Core.DTOs;
using TestApi.DAL.Entity;

namespace TestApi.Core.Abstract
{
    public interface IMyService
    {
        public void AddToDo(ToDoListDTO toDoListDTO);
        public void RemoveFromToDo(ToDoList toDoList);
        public IEnumerable<ToDoList> GetAllList();
    }
}
