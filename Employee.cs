using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartShelfMonitor
{
    class Employee
    {
        public string EmployeeId { get; set; }
        public void requestAvailableShelf()
        {
            WarehouseManager.Instance.findAvailableShelf();
        }
    }
}