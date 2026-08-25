using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class Driver
    {
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Driver(string fullName)
        {
            FullName = fullName;
        }

    }
}
