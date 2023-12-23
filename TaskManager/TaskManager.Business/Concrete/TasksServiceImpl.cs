using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Business.Abstract;
using TaskManager.DataAccess.Abstract;
using TaskManager.DataAccess.Concrete;
using TaskManager.Entities;

namespace TaskManager.Business.Concrete
{
    public class TasksServiceImpl : ITasksService
    {

        private ITasksRepository _tasksRepository;

        public TasksServiceImpl()
        {
            _tasksRepository = new TasksRepository();
        }

        public Tasks CreateTask(Tasks task)
        {
            return _tasksRepository.CreateTask(task);
        }

        public void DeleteTask(int id)
        {
            if(id > 0)
                _tasksRepository.DeleteTask(id);
            else
                throw new Exception("Id must be greater than 0");

        }

        public List<Tasks> GetAllTasks()
        {
            return _tasksRepository.GetAllTasks();

        }

        public Tasks GetTaskById(int id)
        {
            return _tasksRepository.GetTaskById(id);
        }

        public List<Tasks> GetTasksInOneMonth()
        {
            DateTime oneMonthFromNow = DateTime.Now.AddMonths(1);
            return _tasksRepository.GetTasksByDeadline(oneMonthFromNow);
        }

        public List<Tasks> GetTasksInOneWeek()
        {
            DateTime oneWeekFromNow = DateTime.Now.AddDays(7);
            return _tasksRepository.GetTasksByDeadline(oneWeekFromNow);
        }

        public List<Tasks> GetTasksInToday()
        {
            DateTime today = DateTime.Now;
            return _tasksRepository.GetTasksByDeadline(today);
            
        }

        public Tasks UpdateTask(Tasks task)
        {
            return _tasksRepository.UpdateTask(task);
        }
    }
}
