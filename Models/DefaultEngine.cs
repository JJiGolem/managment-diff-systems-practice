using System;
using System.Collections.Generic;
using System.Text;

namespace ForDifferent.Models
{
    class DefaultEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Двигатель запущен.");
            base.Start();
        }

        public override void Stop()
        {
            Console.WriteLine("Двигатель выключен.");
            base.Stop();
        }
    }
}
