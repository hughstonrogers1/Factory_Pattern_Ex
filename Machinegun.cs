using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Machinegun : IFirearm
    {
        public string FeedType { get; set; }
        public int Capacity { get; set; }

        public void LockLoad()
        {
            Console.WriteLine("Ya, you didn't bring enough ammo!");
        }

    }
}
