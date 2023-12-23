using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataAccess.Abstract;
using TaskManager.Entities;

namespace TaskManager.DataAccess.Concrete
{
    public class TasksRepository : ITasksRepository
    {
        
           

        public Tasks CreateTask(Tasks task)
        {
            using (var context = new TaskManagerDbContext())
            {
                context.Tasks.Add(task);
                context.SaveChanges();

                return task;
            }
        }

        public void DeleteTask(int id)
        {
            using (var context = new TaskManagerDbContext())
            {
                var deletedTask = GetTaskById(id);
                context.Tasks.Remove(deletedTask);
                context.SaveChanges();
            }
        }

        public List<Tasks> GetAllTasks()
        {
            using (var context = new TaskManagerDbContext())
            {
                return context.Tasks.ToList();
            }
        }

        public Tasks GetTaskById(int id)
        {
            using (var context = new TaskManagerDbContext())
            {
                return context.Tasks.Find(id);
            }
        }

        public Tasks UpdateTask(Tasks task)
        {
            using (var context = new TaskManagerDbContext())
            {
                context.Tasks.Update(task);
                context.SaveChanges();
                return task;
            }
        }

        public List<Tasks> GetTasksByDeadline(DateTime deadline)
        {
            using (var context = new TaskManagerDbContext())
            {
                List<Tasks> tasks = context.Tasks.Where(t => t.TaskEndDate <= deadline).ToList();
                return tasks;
            }
          
        }

    }
}
