using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class BattleRifle : IFirearm
    {
        public string Action { get; set; }
        public int Capacity { get; set; }

        public void LockLoad()
        {
            Console.WriteLine("You are ready for the range!");
        }

    }
}
