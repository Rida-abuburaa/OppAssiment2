using OppAssiment2.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class PriorityinternationalShipment:InternationalShipment
    {
        public PriorityinternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination, customsFee)
        {
           

        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Priority International Customs Report");
        }

    }
}
