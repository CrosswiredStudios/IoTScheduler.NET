using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTScheduler.Net.Pcl.Database
{
    public sealed class IotSchedulerDatabase
    {
        private SQLiteConnection _database;

        public IotSchedulerDatabase()
        {
            //_database = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "iotSchedNet.sqlite"));
        }

        public SQLiteConnection Database
        {
            get
            {
                return _database;
            }
        }

        public void Initialize()
        {
            
        }
    }
}
