using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTScheduler.Net
{
    public sealed class IoTSchedulerTask
    {
        #region Properties

        #region Private

        private TimeSpan _startTime;
        private DateTime _startDate;
        private TaskFunction _command;

        #endregion

        #region Public

        public TaskFunction Command
        {
            get
            {
                return _command;
            }
        }

        public TimeSpan StartTime
        {
            get
            {
                return _startTime;
            }
        }

        public delegate void TaskFunction();

        #endregion

        #endregion

        #region Constructors


        #endregion

        #region Methods
        #endregion
    }
}
