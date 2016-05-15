using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Car car1 = new Car();
            car1.Make = "Oldmobile";
            car1.Model = "Cutlas Superme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";*/

            /*  List<Car> mylist = new List<Car>();

              mylist.Add(car1);
              mylist.Add(car2);

              foreach (Car car in mylist)
              {
                  //No casting!
                  Console.WriteLine(car.Model);
              }*/

            /* Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
             myDictionary.Add(car1.Make, car1);
             myDictionary.Add(car2.Make, car2);
             Console.WriteLine(myDictionary["Oldmobile"].Model);*/

            string[] name = { "Bob", "Steve", "Brian", "Chuck" };

            Car car1 = new Car() { Make = "Oldsmobile", Model = "Cutlas Supreme" };
            Car car2 = new Car() { Make = "Geo", Model = "Prime" };
            Car car3 = new Car() { Make = "Nissan", Model = "Altima" };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
