using System;

namespace ForDifferent.Models
{
    class MachineEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Станок включен.");
            base.Start();
        }

        public override void Stop()
        {
            Console.WriteLine("Станок выключен.");
            base.Stop();
        }
    }
}
