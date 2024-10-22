using HomeApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{
    public class RemakeDeviceQuery
    {
        public string NewName { get; }
        public string NewManufacturer { get; }
        public string NewModel { get; }
        public string NewSerial { get; }
        public int NewCurrentVolts { get; }
        public bool NewGasUsage { get; }
        public string NewRoom {  get; }

        public RemakeDeviceQuery(string newName = null, string newManufacturer = null, string newModel = null,

            string newSerial = null, int newCurrentVolts = 0, bool newGasUsage = false, string newRoom = null)
        {
            NewName = newName;
            NewManufacturer = newManufacturer;
            NewModel = newModel;
            NewSerial = newSerial;
            NewCurrentVolts = newCurrentVolts;
            NewGasUsage = newGasUsage;
            NewRoom = newRoom;
        }
    }

}
