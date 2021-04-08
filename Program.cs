using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to pick from the armory?");
            string userInput = Console.ReadLine();

            ArmoryFactory factory = new ArmoryFactory();
            IFirearm rifle = factory.SelectWeapon(userInput);

            rifle.LockLoad();

            Console.WriteLine("Select another weapon.");
            userInput = Console.ReadLine();

        }

    }
}
