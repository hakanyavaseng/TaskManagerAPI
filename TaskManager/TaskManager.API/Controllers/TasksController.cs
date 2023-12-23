using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Business.Abstract;
using TaskManager.Business.Concrete;
using TaskManager.Entities;

namespace TaskManager.API.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITasksService _tasksService;

        public TasksController()
        {
            _tasksService = new TasksServiceImpl();
        }
        

        /// <summary>
        /// Brings all tasks.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Tasks> GetAll()
        {
            return _tasksService.GetAllTasks();
        }

        /// <summary>
        /// Brings task by ID.
        /// </summary>
        /// <param name="id">ID of task</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Tasks GetById(int id)
        {
            return _tasksService.GetTaskById(id);
        }

        /// <summary>
        /// Adds new task.
        /// </summary>
        /// <param name="task"></param>
        [HttpPost]
        public void AddTask(Tasks task)
        {
           _tasksService.CreateTask(task);
        }


        /// <summary>
        /// Updates task.
        /// </summary>
        /// <param name="task"></param>
        [HttpPut]
        public void UpdateTask(Tasks task)
        {
            _tasksService.UpdateTask(task);
        }

        /// <summary>
        /// Deletes task by ID.
        /// </summary>
        /// <param name="id">ID of task to be deleted</param>
        [HttpDelete("{id}")]
        public void DeleteTask(int id)
        {
            _tasksService.DeleteTask(id);
        }


        /// <summary>
        /// Brings tasks by deadline which is given as parameter.
        /// </summary>
        [HttpGet("today")]
        public void GetTasksInOneDay()
        {
            _tasksService.GetTasksInToday();
        }

        /// <summary>
        /// Brings tasks by deadline which is given as parameter.
        /// </summary>
        [HttpGet("oneweek")]
        public void GetTasksInOneWeek()
        {
            _tasksService.GetTasksInOneWeek();
        }

        /// <summary>
        /// Brings tasks by deadline which is given as parameter.
        /// </summary>
        [HttpGet("onemonth")]
        public void GetTasksInOneMonth()
        {
            _tasksService.GetTasksInOneMonth();
        }
        



       
    }
}
