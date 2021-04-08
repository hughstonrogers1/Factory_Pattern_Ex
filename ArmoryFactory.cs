using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class ArmoryFactory
    {
        public IFirearm SelectWeapon(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "battle rifle":
                    return new BattleRifle();
                case "machinegun":
                    return new Machinegun();
                default:
                    return new BattleRifle() { Action = "Bolt" };
            }
        }

    }
}
