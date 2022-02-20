using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Implement
{
    public class TaskService : IService
    {

        public static List<TaskModel> taskModels = new List<TaskModel> {
         new TaskModel{
             ID = 1,
             Title = "Is Graduated",
             IsComplete = false
         },
         new TaskModel{
             ID = 2,
             Title = "Buy Car",
             IsComplete = false
         },
         new TaskModel{
             ID = 3,
             Title = "Buy MotoCar",
             IsComplete = false
         },
         new TaskModel{
             ID = 4,
             Title = "Buy Laptop",
             IsComplete = true
         },
         new TaskModel{
             ID = 5,
             Title = "Go to School",
             IsComplete = true
         },
         new TaskModel{
             ID = 6,
             Title = "Buy Laptop",
             IsComplete = true
         }
     };



        public List<TaskModel> All()
        {
            return taskModels;
        }

        public void Create(TaskModel task)
        {
            taskModels.Add(task);
        }



        public void Delete(int id)
        {
            var taskDelete = taskModels.Where(x => x.ID == id).FirstOrDefault();

            taskModels.Remove(taskDelete);

        }

        public void Edit(TaskModel task)
        {
            var taskEdit = taskModels.Where(x => x.ID == task.ID).FirstOrDefault();
            taskEdit.Title = task.Title;
            taskEdit.IsComplete = task.IsComplete;
        }

        public IEnumerable<TaskModel> getAll()
        {
            return taskModels;
        }

        public TaskModel GetById(int id)
        {

            var oneTask = taskModels.Where(x => x.ID == id).FirstOrDefault();
            return oneTask;
        }
        public void CreateMulti(List<TaskModel> task)
        {
            foreach (TaskModel taskMulti in task)
            {
                taskModels.Add(taskMulti);
            }

        }
        public void DeleteMulti(List<int> idDeleteMulti)
        {
            foreach (int multiDelete in idDeleteMulti)
            {
                TaskModel task = taskModels.Where(x => x.ID == multiDelete).FirstOrDefault();
                taskModels.Remove(task);
            }
        }
    }
}