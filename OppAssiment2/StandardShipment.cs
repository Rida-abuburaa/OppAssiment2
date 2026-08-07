using OppAssiment2.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class StandardShipment:Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
      

        }

    }
}
