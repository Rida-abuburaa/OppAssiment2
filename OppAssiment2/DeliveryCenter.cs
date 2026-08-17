using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2
{
    internal class DeliveryCenter
    {
        private Shipment[]? shipments = new Shipment[20];
       
        public int CenterName { get; set; }
        public Driver Driver { get; set; }
        // Integer indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return null;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        // String indexer (search by tracking code)
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment != null && shipment.trackingCode == trackingCode)
                        return shipment;
                }

                return null;
            }
        }

        // Add shipment to the first empty position
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false; // Center is full
        }

        public bool RemoveShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == shipment)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false; // Shipment not found
        }

       
        //Assiment2
       /* public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                }
            }
        }*/


       //Assiment3
       public void PrintAllShipments()
       {
        foreach (Shipment shipment in shipments)
        {
            shipment.PrintShipment();
        }
}

       public void PrintTrackingStatuses()
        {
            foreach (ITrackable shipment in shipments)
            {
               Console.WriteLine( shipment.GetTrackingStatus());

            }
        }


        public void PrintIInsurableStatuses()
        {
            foreach (IInsurable shipment in shipments)
            {
                Console.WriteLine(shipment.CalculateInsurance());

            }
        }


    }
}
