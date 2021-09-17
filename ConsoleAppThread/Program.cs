using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using HomeWorkNumberSeventeen;

namespace ConsoleAppThread
{
    class Program
    {
        static void Action(List<Car> cars)
        {          
            foreach (var car in cars)
            {
                car.Age = (343 * 34 * 2 * 77) / 567;
            }
        }

        static void Action1(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].Age = (343 * 34 * 2 * 77) / 567;
            }
        }

        static void Action2(List<Car> cars)
        {
            Parallel.ForEach(cars, car => { car.Age = (343 * 34 * 2 * 77) / 567; });
        }

        static void Action3(List<Car> cars)
        {
            Parallel.For(0, cars.Count, index => { cars[index].Age = (343 * 34 * 2 * 77) / 567; });
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            for (int i = 0; i < 100000000; i++)
            {
                cars.Add(new Car(i));
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Action(cars);
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            Action1(cars);
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            Action2(cars);
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            Action3(cars);
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}
