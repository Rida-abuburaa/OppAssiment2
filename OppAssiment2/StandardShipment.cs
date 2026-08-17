using OppAssiment2.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class StandardShipment : Shipment,ITrackable,IInsurable
    {
     
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {


        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) ;

            }
        }
        public override void PrintShipment()
        {
            Console.WriteLine("InternationalShipment");
            Console.WriteLine($"TrackingCode :{trackingCode}\n Description:{description}\n Weight:{weight}KG\n DeliveryFee:{deliveryFee} EGP\n Cost:{EstimatedCost}");
        }
        
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public decimal CalculateInsurance()
        {
            return  EstimatedCost * 0.05m;
        }


    }

    
    }
