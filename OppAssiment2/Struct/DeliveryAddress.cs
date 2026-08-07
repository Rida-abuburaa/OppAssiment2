using System;
using System.Collections.Generic;
using System.Text;

namespace OppAssiment2.Struct
{
    internal struct DeliveryAddress
    {
      //private  string City;
      //private  string Street;
      // private int BuildingNumber;

        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public DeliveryAddress( string city , string street , int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

       
        //public string GetFullAddress()
        //{
        //   return $"{BuildingNumber}, {Street}, {City}";
       // }


        public override string ToString()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }
    }
}
