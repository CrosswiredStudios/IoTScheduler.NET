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
        // Add a scheduler to the class
        private IoTScheduler _scheduler = new IoTScheduler();

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            // Initialize the scheduler
            _scheduler.Initialize();

            // Create a task
            IoTSchedulerTask task = new IoTSchedulerTask();
            task.StartTime = new TimeSpan(15, 30, 0);
            task.Callback += new IoTSchedulerTask.CallbackEventHandler(TaskFunction);

            // Add the task to the scheduler
            _scheduler.AddTask(task);

            while(true)
            {
                Task.Delay(1000);
            }

        }

        private void TaskFunction()
        {
            Debug.WriteLine("Fired Task");
        }
    }
}
