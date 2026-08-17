using OppAssiment2.Struct;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Timers;
using static OppAssiment2.DeliveryHelper;

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







            //Question 3 practical Assiment2 
            /* DeliveryCenter d1 = new DeliveryCenter();

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






            #region Assiment 3 Part 01 — Theoretical Questions

            // Q1 Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?
            /* Overloading:
            -Same method name, different parameters.
            - Usually in the same class.
            -Uses virtual/override? No.
            -Compile-time binding*/
            /* Overriding:
                 -Same method signature.
                 -Requires inheritance.
                 - Uses virtual + overrid.
                 -Runtime/dynamic binding.*/


            //b)  What is the difference between Static Binding and Dynamic Binding?
            /* Static Binding:
                 -Decided at compile time.
                 - Common with method overloading.
                 - Based on declared type / arguments.
                 - Faster / early decision.*/
            /*  Dynamic Binding:
                  -Decided at runtime.
                  -Common with method overriding.
                  - Based on actual object type.
                  -Runtime decision.*/



            #endregion

            #region Assiment3 practical****************************************************************************************************************

            /* Driver driver = new Driver("Ahmed Ali");
            DeliveryCenter center = new DeliveryCenter();
            DeliveryAddress address1 = new DeliveryAddress("Cairo", "reda123", 234);
            DeliveryAddress address2 = new DeliveryAddress("Giza", "ahmed456", 567);
            DeliveryAddress address3 = new DeliveryAddress("Alexandria", "mohamed789", 890);



            center.Driver = driver;
            Console.WriteLine(driver.FullName);
            Console.WriteLine("==========================================");
            StandardShipment standard = new StandardShipment("S001", "Laptop", 12m, 10m, address1);

            ExpressShipment express = new ExpressShipment("3001","glasses",4m,32m,address2,5m);

            InternationalShipment international = new InternationalShipment("1001","Glasses",22m,21m,address3,23m);
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            Shipment[] shipments =
              {
              standard,
              express,
              international
             };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
                Console.WriteLine("==========================================");
            }
            // CompletedShipment is sealed,
            // so no class can inherit from it.
            CompletedShipment completed = new CompletedShipment();
            // GenerateCustomsReport() is sealed in PriorityInternationalShipment,
            // so classes derived from PriorityInternationalShipment
            // cannot override this method.
            PriorityinternationalShipment priority = new PriorityinternationalShipment("1001","kall",2,3,address1,4);
            priority.GenerateCustomsReport();*/



            #endregion


            DeliveryAddress address1 = new DeliveryAddress("Cairo", "reda123", 234);
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            StandardShipment st1 = new StandardShipment("2001","Laptop",12,10, address1);
            ExpressShipment ex1 = new ExpressShipment("3001", "glasses", 4m, 32m, address1, 5m);
            InternationalShipment inr1 = new InternationalShipment("1001", "Glasses", 22m, 21m, address1, 23m);

            deliveryCenter.AddShipment(st1);
            deliveryCenter.AddShipment(ex1);
            deliveryCenter.AddShipment(inr1);

            Shipment[] shipments =
            {
              st1,
              ex1,
              inr1
             };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
                Console.WriteLine("==========================================");
               
            }
            ITrackable[] trackableShipments =
            {
              st1,
              ex1,
              inr1
            };
            Console.WriteLine("Tracking Status");
            foreach (ITrackable shipment in trackableShipments)
            {
               
                Console.WriteLine(shipment.GetTrackingStatus());
                
            }
            IInsurable[] insurableShipments =
            {
                st1,
                ex1,
                inr1

            };
            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            
                Console.WriteLine($"Standard Shipment Insurance : {st1.CalculateInsurance():F2} EGP");
                Console.WriteLine($"Express Shipment Insurance : {ex1.CalculateInsurance():F2} EGP");
                Console.WriteLine($"International Shipment Insurance : {inr1.CalculateInsurance():F2} EGP"); 
            
            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

        }
    }
}
