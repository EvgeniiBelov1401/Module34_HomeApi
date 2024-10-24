﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models.Devices
{
    public class EditAllDeviceRequest
    {
        public string NewName { get; set; }
        public string NewManufacturer { get; set; }
        public string NewModel { get; set; }
        public string NewSerial { get; set; }
        public int NewCurrentVolts { get; set; }
        public bool NewGasUsage { get; set; }
        public string NewRoom { get; set; }
    }
}
