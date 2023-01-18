using System;

namespace Event
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FuelLevel = 15;
            car.TanksIsEmpty += () => { Console.WriteLine("Ну а що");};

            #region MyRegion
            car.Drive();
            car.Drive();
            car.Drive();
            #endregion

        }
        
        //static void EventHandler()
        //{
        //    Console.WriteLine("Событие пришло");
        //    Console.WriteLine("Ну вот так");
        //}
    }
}
