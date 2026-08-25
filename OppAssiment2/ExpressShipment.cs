using OppAssiment2.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class ExpressShipment:Shipment,ITrackable,IInsurable
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


        public override decimal EstimatedCost
        {
          get { return deliveryFee + (weight * 5)+ ExtraFee; }
        }


        public override void PrintShipment()
        {
            Console.WriteLine("ExpressShipment");

            Console.WriteLine($"TrackingCode :{trackingCode}\n Description:{description}\n Weight:{weight}KG\n ExtraFee:{ExtraFee}\n DeliveryFee:{deliveryFee} EGP\n Cost:{EstimatedCost}");
        }


        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }


        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }


    }
}
