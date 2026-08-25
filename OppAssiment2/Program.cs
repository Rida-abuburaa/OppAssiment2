using OppAssiment2.Struct;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Timers;
using static OppAssiment2.DeliveryHelper;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region practical OOP04 
            /*  DeliveryAddress address1 = new DeliveryAddress("Cairo", "reda123", 234);
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
              #endregion



              #region OOP04 Theoretical


              //a)  What is Abstraction in Object-Oriented Programming?
              //Abstraction is the process of hiding unnecessary implementation details and showing only the essential features of an object.
              //b)  Why is abstraction considered one of the four pillars of OOP?
              //Hide complex implementation details.
              // Reduce unnecessary code complexity.
              //Make programs easier to understand and maintain.
              //Define a common structure that different classes can follow.

              // a)  What is the difference between an Abstract Class and an Interface?  
              //Abstract Class:
              // Used as a base class for related classes.
              // Can contain fields, properties, constructors, and methods.
              //Can contain methods with actual implementation.
              //A class can inherit from only one abstract class Used to share common data and code.
              //Interface:
              //Defines a contract that a class must follow.
              //Mainly defines methods and properties that the class must implement.
              //A class can implement multiple interfaces.
              //Used to define what a class can do.


              //b)  When would you choose an Interface instead of an Abstract Class?

              //Choose an Interface when you want to define a common behavior or capability that different classes can have.
              //Use an Interface when unrelated classes need to follow the same contract.
              //Use an Interface when a class needs to implement multiple behaviors, because a class can implement multiple interfaces.
              //An Interface is useful when you only need to specify what a class must do, not share common data or implementation.


              //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
              // No. A class can inherit from only one abstract class (or one base class) in C#.
              //Yes. A class can implement multiple interfaces.
            */
            #endregion

            #region Part 01 — Theoretical Questions 

            //a) What happens when you assign one object variable to another object variable?
            // When you assign one object variable to another, only the reference(memory address) is copied, 
            // not the actual object.Both variables point to the same object in memory.

            // b) Does assigning one object to another create a new object? Explain.
            // No.Assigning one object variable to another does not create a new object.
            //It simply copies the reference to the existing object.Therefore, any changes made through one variable will also be visible through the other because they both refer to the same object.

            // c) What is the difference between copying an object and copying its reference?
            // The difference is:
            //Copying an object: Creates a new, independent object with the same data.Changes to the copy do not affect the original.
            //Copying a reference: Creates another reference(pointer) to the same object.Both references refer to the same data,
            //so changes made through one reference affect the object seen through the other.


            // Q2 — Shallow Copy vs Deep Copy
            //a) What is a Shallow Copy?
            //A shallow copy creates a new object, but it copies the values of its members as they are.For reference-type members, it copies the reference rather than creating a new referenced object.

            //b) What is a Deep Copy?
            //A deep copy creates a new object and also creates independent copies of the objects referenced by its reference-type members.

            //c) What happens to reference-type members when a Shallow Copy is created?
            //The reference itself is copied, so both the original and copied objects point to the same referenced object.
            //Therefore, changing that referenced object through one copy can affect the other.

            //d) What happens to reference-type members when a Deep Copy is created?
            //The referenced objects are copied into new, independent objects. The original and copied objects therefore have separate reference - type members.
            //Changes to one copy do not affect the other.

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //A Deep Copy would be safer when copying an object that contains a list of data that should be modified independently.
            //For example, if you copy a Student object containing a list of courses, a deep copy ensures that adding or removing courses from the copied student's list does not change the original student's list.



            // Q3 — Static Members
            //a) What is a static field, and how is it different from an instance field ?
            //A static field belongs to the class itself, not to a specific object.There is only one copy of a static field, shared by all objects of that class.
            //An instance field belongs to a specific object. Each object has its own separate copy.

            //b) What is a static method? Can a static method directly access instance members?
            //A static method belongs to the class rather than to an object. It can be called using the class name.
            //A static method cannot directly access instance members, because it does not belong to a specific object.
            //It can access instance members if it receives an object/reference to the class.

            //c) What is a static constructor, and when is it executed?
            //A static constructor is used to initialize static fields or perform other one - time setup for a class.
            //It:
            //Has the same name as the class.
            //Has no access modifier or parameters.
            //Runs automatically once, before the class is first used.

            // d) What is a static class? Can you create an object from a static class?
            //A static class is a class that cannot be instantiated and normally contains only static members.
            //You cannot create an object from a static class.


            //Q4 — Extension Methods
            //a) What is an Extension Method?
            //An Extension Method is a method that allows you to add new functionality to an existing class or type without modifying its original source code or creating a derived class.

            //b) What keyword must be used in the first parameter of an extension method?
            // The this keyword must be used before the first parameter.

            //c) Where must an extension method be declared?
            //An extension method must be declared inside a static, non-generic class.

            //d) Can an extension method access private members of the class it extends?
            //No.An extension method cannot directly access private members of the class it extends.
            //It can only access members that are accessible to it, such as public members.

            //Q5 — Partial Classes and Partial Methods
            //a) What is a Partial Class?
            //A partial class allows a single class to be divided into multiple files.When the program is compiled, all parts are combined into one class.

            //b) Why would a developer split one class into multiple files?
            //A developer may split a class into multiple files to:
            //Keep large classes organized and easier to read.
            //Allow multiple developers to work on different parts of the class.
            //Separate automatically generated code from manually written code.
            //Make maintenance and development easier.

            //c) What is a Partial Method?
              // A partial method is a method that can be declared in one part of a partial class and optionally implemented in another part of the same class.

           // d) What happens if a declared partial method has no implementation?
              //If a partial method is declared but not implemented, it can be removed by the compiler, so it has no effect on the compiled program.


            #endregion






        }
    }
}
