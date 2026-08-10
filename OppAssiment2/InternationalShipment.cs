using OppAssiment2.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class InternationalShipment:Shipment
    {
        private string DestinationCountry;
        private decimal CustomsFee;

     

        public string destinationCountry
        {
            get { return DestinationCountry; }
            set {

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("the DestinationCountry can not be empty");

                }
                DestinationCountry = value;


            }
        }

        public decimal customsFee
        {
            get { return CustomsFee; }
            set {
                if (value >=0 )
                {
                    CustomsFee = value;
                }
               
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            CustomsFee = customsFee;

        }



        public override decimal EstimatedCost
        {
            get { return deliveryFee + (weight * 5) + CustomsFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("InternationalShipment");
            Console.WriteLine($"TrackingCode :{trackingCode}\n Description:{description}\n Weight:{weight}KG\n CustomsFee:{CustomsFee}\n DeliveryFee:{deliveryFee} EGP\n Cost:{EstimatedCost}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("International Customs Report");
        }

    }
}
