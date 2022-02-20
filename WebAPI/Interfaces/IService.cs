using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IService
    {
        public List<TaskModel> All();
        public IEnumerable<TaskModel> getAll();
        public void Create(TaskModel task);
        public void Edit(TaskModel task);
        public TaskModel GetById(int id);
        public void Delete(int id);
        public void CreateMulti(List<TaskModel> task);
        public void DeleteMulti(List<int> idDeleteMulti);
    }
}