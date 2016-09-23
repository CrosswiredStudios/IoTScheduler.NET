using IoTScheduler.Net.Pcl.Database;
using System;
using System.Collections.Generic;
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

        IotSchedulerDatabase _database;

        #endregion

        #region Public

        #endregion

        #endregion

        #region Constructors

        public IoTScheduler()
        {
            _database = new IotSchedulerDatabase();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds a task to the scheduler
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public AddTaskResult AddTask(IoTSchedulerTask task)
        {
            Timer timer;
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = task.StartTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                //time already passed
            }
            timer = new System.Threading.Timer(x =>
            {
                task.Command();
            }, null, timeToGo, Timeout.InfiniteTimeSpan);

            return new AddTaskResult();
        }

        /// <summary>
        /// Initializes the scheduler
        /// </summary>
        /// <returns></returns>
        public bool Initialize()
        {
            _database.Initialize();
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

        #endregion
    }
}
