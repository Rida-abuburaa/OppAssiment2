using OppAssiment2.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal abstract class Shipment
    {
        public string TrackingCode;
        private string Description;
        public decimal Weight;
        public decimal DeliveryFee;
        private  DeliveryAddress Destination;

        public abstract decimal EstimatedCost { get; }




        public string trackingCode
        {
            get { return TrackingCode; }
        
        }


        public string description
        {
            get { return Description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("the name can not be empty");

                }
                Description = value;


            }
        }

        public decimal weight
        {
            get { return Weight; }
            set {
                if (value<0)
                {
                    Console.WriteLine("weight must be more than zero");

                }

                Weight = value;
            }
        }


        public decimal deliveryFee
        {
            get { return DeliveryFee; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("DeliveryFee must be more than zero");

                }

                DeliveryFee = value;
            }
        }


        public DeliveryAddress destination { get; set; }
       /* public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }*/


    
        //Constructors
        public Shipment(string trackingCode)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                TrackingCode = trackingCode;
            }
        }


        public Shipment()
        {
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;

        }

        public Shipment(string trackingCode, string description, decimal weight , decimal deliveryFee, DeliveryAddress destination)
        {

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }


        //Methods 
       public decimal UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                 DeliveryFee += newFee;
            }
            return DeliveryFee;
        }


        /*public  virtual void PrintShipment()
        {
            Console.WriteLine($"TrackingCode :{TrackingCode}\n Description:{Description}\n Weight:{Weight}KG\n DeliveryFee:{DeliveryFee} EGP\n Cost:{EstimatedCost}");
        }*/

        public abstract void PrintShipment();



    }
}
