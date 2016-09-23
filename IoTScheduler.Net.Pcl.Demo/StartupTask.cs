using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;
using IoTScheduler.Net;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace IoTScheduler.Net.Pcl.Demo
{
    public sealed class StartupTask : IBackgroundTask
    {

        private IoTScheduler _scheduler;

        public void Run(IBackgroundTaskInstance taskInstance)
        {

            _scheduler.Initialize();

        }
    }
}
