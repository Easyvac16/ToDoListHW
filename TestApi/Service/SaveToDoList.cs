using Newtonsoft.Json;
using TestApi.Abstract;

namespace TestApi.Service
{
    public class SaveToDoList: ISaveToDoList
    {
        /*public void SaveList(List<ToDoList> toDoLists)
        {
            string filePath = "todolist.json";
            List<ToDoList> existingToDoLists = new List<ToDoList>();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                existingToDoLists = JsonConvert.DeserializeObject<List<ToDoList>>(existingJson);
            }

            existingToDoLists.AddRange(toDoLists);

            string updatedJson = JsonConvert.SerializeObject(existingToDoLists, Formatting.Indented);

            File.WriteAllText(filePath, updatedJson);
        }*/
    }
}
