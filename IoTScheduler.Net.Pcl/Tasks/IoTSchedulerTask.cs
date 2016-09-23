using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTScheduler.Net
{
    /// <summary>
    /// Task object used for scheduling by IoTScheduler
    /// </summary>
    public sealed class IoTSchedulerTask
    {
        #region Properties

        #region Private

        private TimeSpan _startTime;
        private DateTime _startDate;
        private CallbackEventHandler _callback;

        #endregion

        #region Public

        public CallbackEventHandler CallbackFunction
        {
            get
            {
                return _callback;
            }
            set
            {
                _callback = value;
            }
        }

        /// <summary>
        /// TimeSpan representing the hour, minute, and second to fire the callback at
        /// </summary>
        public TimeSpan StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }

        public delegate void CallbackEventHandler();
        public event CallbackEventHandler Callback;

        #endregion

        #endregion

        #region Constructors

        /// <summary>
        /// Instantiates a blank task
        /// </summary>
        public IoTSchedulerTask()
        {

        }

        #endregion

        #region Methods

        public void FireCallback()
        {
            
            if (Callback != null)
                Callback();
        }
        #endregion
    }
}
