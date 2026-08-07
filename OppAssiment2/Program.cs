using OppAssiment2.Struct;
using System.Security.Cryptography.X509Certificates;

namespace OppAssiment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // QUESTION1
            //a) What is the difference between a class and a struct?
            //CLASS                                                       STRUCT 
            // Reference type                                                 Value type
            //Can have inheritance                                           Can not have inheritance
            //can be null                                                    can not be null
            //Better for large objects and complex behavior                  Better for small, simple data objects
            //Assignment copies the reference                                Assignment copies the entire value


            //b) Why are classes more suitable than structs for large applications?
            //Support inheritance and polymorphism
            //Handle large data efficiently
            //Allow shared references
            //Support more complex behavior
            //Can represent real-world entities


            //Question2
            //a) Which class is the parent class?
            //shipment
            //b) Which class is the child class?
            //ExpressShipment
            //c) What members are inherited by ExpressShipment?
            //TrakingCode
            //d) Why is inheritance better than duplicating the same code in multiple classes?
            //Inheritance is better because it allows code reuse and avoids repeating the same code in multiple classes.
            //Instead of writing the same properties and methods in different classes, we create a base class that contains the common code, and other classes inherit from it.






            /*
            //Question 3 practical
              DeliveryCenter d1 = new DeliveryCenter();

              for (int i = 0; i < 3; i++)
              {
                  Console.WriteLine("TrackingCode:");
                  string tracode = Console.ReadLine();

                  Console.WriteLine("Description:");
                  string desscr = Console.ReadLine();

                  Console.WriteLine("Weight:");
                  decimal wei = decimal.Parse(Console.ReadLine());

                  Console.WriteLine("DeliveryFee:");
                  decimal dele = decimal.Parse(Console.ReadLine());

                  Console.WriteLine("City:");
                  string cit = Console.ReadLine();

                  Console.WriteLine("Street:");
                  string stree = Console.ReadLine();

                  Console.WriteLine("Building Number:");
                  int bnumber = int.Parse(Console.ReadLine());

                  DeliveryAddress address = new DeliveryAddress(cit, stree, bnumber);

                  Shipment shipment;

                  if (i == 0)
                  {
                      // First shipment = Standard

                      shipment = new StandardShipment(tracode, desscr, wei, dele, address);
                  }
                  else if (i == 1)
                  {
                      // Second shipment = Express
                      Console.WriteLine("ExtraFee:");
                      decimal extraFee = decimal.Parse(Console.ReadLine());


                      shipment = new ExpressShipment(tracode, desscr, wei, dele, address, extraFee);
                  }
                  else
                  {
                      // Third shipment = International
                      Console.WriteLine("CustomsFee:");
                      decimal customsFee = decimal.Parse(Console.ReadLine());

                      shipment = new InternationalShipment(tracode, desscr, wei, dele, address, customsFee);
                  }

                  if (d1.AddShipment(shipment))
                  {
                      Console.WriteLine("Shipment added successfully.");
                  }
              }

              Console.WriteLine("------------ All Shipments ------------");
              d1.PrintAllShipments();*/
        }
    }
}
