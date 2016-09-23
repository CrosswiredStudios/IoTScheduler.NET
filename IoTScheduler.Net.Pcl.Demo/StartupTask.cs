using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;
using IoTScheduler.Net;
using System.Diagnostics;
using System.Threading.Tasks;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace IoTScheduler.Net.Pcl.Demo
{
    public sealed class StartupTask : IBackgroundTask
    {
        /// <summary>
        /// Scheduling System
        /// </summary>
        private IoTScheduler _scheduler = new IoTScheduler();

        /// <summary>
        /// Windows program entry point
        /// </summary>
        /// <param name="taskInstance"></param>
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            // Initialize the scheduler
            _scheduler.Initialize();

            // Create a task
            IoTSchedulerTask task = new IoTSchedulerTask();

            // Set the start time (24-hour time HH, MM, SS)
            task.StartTime = new TimeSpan(15, 30, 0);

            // Add the function to the handler
            task.Callback += new IoTSchedulerTask.CallbackEventHandler(TaskFunction);

            // Add the task to the scheduler
            _scheduler.AddTask(task);

            // Loop 4fuckineva
            while(true)
            {
                Task.Delay(1000);
            }

        }

        /// <summary>
        /// Some function in your project
        /// </summary>
        private void TaskFunction()
        {
            Debug.WriteLine("Fired Task");
        }
    }
}
