using System;
using System.IO;

namespace CourseProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Client("Валерий Жмышенко", 1);
            var s2 = new Client("Олег", 2);
            var s3 = new Client("Санта Клаус", 3);
            var s4 = new Client("Johnny Silverhand", 4);
            var s5 = new Client("Carlos", 5);
            var s6 = new Client("Mickey", 225);

            Service service = new Service("Легкий некстген", "8 Mile Rd.");
            Console.WriteLine("Имечко местной конторки перекупщиков: " + service.Name + "\n" + "Адрес: " + service.Address + "\n");

            service.Add(s1);
            service.Add(s2);
            service.Add(s3);

            Console.WriteLine("\nОчередь на данный момент:");

            foreach (var s in service)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();

            service.Buy();
            service.Buy();
            service.Add(s4);
            service.Add(s5);
            service.Add(s6);

            Console.WriteLine("\nОчередь на данный момент:");

            foreach (var s in service)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();

            service.Mistake();
            service.GetAway(s4);

            Console.WriteLine("\nОчередь на данный момент:");

            foreach (var s in service)
            {
                Console.WriteLine(s.Name);
            }

            Console.ReadKey();
        }
    }
}
