using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTScheduler.Net
{
    public sealed class AddTaskResult
    {
        #region Properties

        #region Private
        
        private int _taskId;

        #endregion

        #region Public

        public int TaskId
        {
            get
            {
                return _taskId;
            }
        }

        #endregion

        #endregion

        #region Constructors

        public AddTaskResult()
        {
            _taskId = -1;
        }

        #endregion

        #region Methods
        #endregion
    }
}
