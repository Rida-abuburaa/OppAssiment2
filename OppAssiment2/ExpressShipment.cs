using OppAssiment2.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class ExpressShipment:Shipment
    {
      private  decimal ExtraFee;

		

		public decimal extraFee
		{
			get { return ExtraFee; }
			set { 
				if (value>=0)
				{
                    ExtraFee = value;
                }
				
			}
		}

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination , decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;

        }


        public  decimal EstimatedCost
        {
          get { return base.deliveryFee + (base.weight * 5)+ ExtraFee; }
        }

    }
}
