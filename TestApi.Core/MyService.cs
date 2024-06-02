using TestApi.Core.Abstract;
using TestApi.Core.DTOs;
using TestApi.Core.Enum;
using TestApi.DAL.Abstract;
using TestApi.DAL.Entity;

namespace TestApi.Core
{
    public class MyService : IMyService
    {
        private readonly IMyRepository _listRepository;

        public MyService(IMyRepository listRepository)
        {
            _listRepository = listRepository;
        }
        public void AddToDo(ToDoListDTO toDoListDTO)
        {
            var newToDo = MapToDo(toDoListDTO);

            _listRepository.Add(newToDo);
        }

        public ToDoList GetById(int id) =>
            _listRepository.GetById<ToDoList>(id);
        public void RemoveFromToDo(ToDoList toDoList) =>
            _listRepository.Remove(toDoList);

        public IEnumerable<ToDoList> GetAllList() =>
            _listRepository.GetAll<ToDoList>().ToList();

        private ToDoList MapToDo(ToDoListDTO toDoListDTO)
        {
            return new ToDoList
            {
                Description = toDoListDTO.Description,
                Name = toDoListDTO.Name,
                Status = ToDoEnum.InProgress
            };
        }
    }
}
