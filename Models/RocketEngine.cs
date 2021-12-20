using System;

namespace ForDifferent.Models
{
    class RocketEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Ракета запущена.");
            base.Start();
        }

        public override void Stop()
        {
            Console.WriteLine("Ракета деактивирована.");
            base.Stop();
        }
    }
}
