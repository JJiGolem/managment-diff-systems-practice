using System;
using System.Collections.Generic;
using ForDifferent.Interfaces;
using ForDifferent.Models;

namespace ForDifferent
{
    class Program
    {
        private static List<ISystem> _systems;
        public static void Main(string[] args)
        {
            _systems = new List<ISystem>()
            {
                new Car(),
                new Rocket(),
                new Machine()
            };

            //var cars = new List<Car>()
            //{
            //    new Car(),
            //    new Car(),
            //};

            //var rockets = new List<Rocket>()
            //{
            //    new Rocket(),
            //    new Rocket(),
            //};

            //var machines = new List<Machine>()
            //{
            //    new Machine(),
            //    new Machine(),
            //};

            RemoteControlPanel<ISystem> remoteControl = new RemoteControlPanel<ISystem>(_systems);
            //RemoteControlPanel<Car> remoteControl1 = new RemoteControlPanel<Car>(cars);
            //RemoteControlPanel<Rocket> remoteControl2 = new RemoteControlPanel<Rocket>(rockets);
            //RemoteControlPanel<Machine> remoteControl3 = new RemoteControlPanel<Machine>(machines);

            bool isOpen = true;
            while(isOpen)
            {
                remoteControl.ShowCommands();
                remoteControl.ReadCommand(ref isOpen);
                Console.WriteLine("Нажмите, чтобы продолжить..");
                Console.ReadKey();
            }
        }
    }
}
