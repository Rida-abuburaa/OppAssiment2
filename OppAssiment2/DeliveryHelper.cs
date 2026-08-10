using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            shipment.PrintShipment();
        }
        public sealed class CompletedShipment : Shipment
        {
        }
    }
}
