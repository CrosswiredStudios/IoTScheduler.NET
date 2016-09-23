using IoTScheduler.Net.Pcl.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IoTScheduler.Net
{
    public sealed class IoTScheduler
    {
        #region Properties

        #region Private

        private Timer _timer;
        private List<IoTSchedulerTask> _tasks;

        #endregion

        #region Public

        public List<IoTSchedulerTask> Tasks
        {
            get
            {
                return _tasks;
            }
        }


        #endregion

        #endregion

        #region Constructors

        public IoTScheduler()
        {
            _tasks = new List<IoTSchedulerTask>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a task to the scheduler
        /// </summary>
        /// <param name="task">The task to add to the scheduler</param>
        /// <returns>Returns a AddTaskResult with all relevant information</returns>
        public AddTaskResult AddTask(IoTSchedulerTask task)
        {
            Debug.WriteLine("IoTScheduler: Adding task");
            
            // Determine the difference in time between the desired time and now
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = task.StartTime - current.TimeOfDay;

            // If we have passed the desired time to execute, do nothing
            if (timeToGo < TimeSpan.Zero)
            {
                Debug.WriteLine("IoTScheduler: Too late, desired time has passed");
                return new AddTaskResult();
            }

            // Add the task to the list of tasks for today
            _tasks.Add(task);

            //// Initialize the timer to call the function
            //timer = new System.Threading.Timer(x =>
            //{
            //    Debug.WriteLine("IoTScheduler: Firing task");
            //    task.FireCallback();
            //    _timers.Remove(timer);
            //}, null, timeToGo, Timeout.InfiniteTimeSpan);

            //_timers.Add(timer)

            return new AddTaskResult();
        }

        /// <summary>
        /// Initializes the scheduler
        /// </summary>
        /// <returns></returns>
        public bool Initialize()
        {
            //_database.Initialize();
            return true;
        }

        /// <summary>
        /// Removes a task from the scheduler
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public AddTaskResult RemoveTask(int taskId)
        {
            return new AddTaskResult();
        }

        // Get all tasks that will need to fire next.
        private List<IoTSchedulerTask> GetNextTasks()
        {
            // Create a variable to hold the soonest task
            IoTSchedulerTask nextTask = new IoTSchedulerTask();

            // Go through all the tasks in the stack
            foreach(IoTSchedulerTask task in _tasks)
            {
                // If this is the first item in the stack (since newTask will have null values)
                if(nextTask.StartTime == null)
                {
                    // Set the next task to the first item
                    nextTask = task;
                }

                // If this task starts before the task marked as next
                if (task.StartTime < nextTask.StartTime)
                {
                    // Make this task the next task
                    nextTask = task;
                }
            }

            // Get all tasks that fire at this time
            List<IoTSchedulerTask> allTasks = _tasks.Where(t => t.StartTime == nextTask.StartTime).ToList();

            // Return the next task
            return allTasks;
        }
        #endregion
    }
}
