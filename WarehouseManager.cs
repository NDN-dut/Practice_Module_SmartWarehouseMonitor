using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShelfMonitor
{
    class WarehouseManager
    {
        private static WarehouseManager _Instance;
        public static WarehouseManager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new WarehouseManager();
                return _Instance;
            }
            private set { }
        }
        public void findAvailableShelf()
        {
            
        }
    }
}