using System;

namespace ForDifferent.Models
{
    class CarEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Машина заведена.");
            base.Start();
        }

        public override void Stop()
        {
            Console.WriteLine("Машина выключена.");
            base.Stop();
        }
    }
}
