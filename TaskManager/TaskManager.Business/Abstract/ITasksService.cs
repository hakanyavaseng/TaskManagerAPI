using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Entities;

namespace TaskManager.Business.Abstract
{
    public interface ITasksService
    {
        List<Tasks> GetAllTasks();
        Tasks GetTaskById(int id);
        Tasks CreateTask(Tasks task);
        Tasks UpdateTask(Tasks task);
        void DeleteTask(int id);




    }
}
