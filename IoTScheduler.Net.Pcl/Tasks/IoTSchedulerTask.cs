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
