using System;

namespace BobAndGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.WriteLine("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") { return; }
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Who should we give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "joe")
                    {
                        joe.GiveCash(amount);
                        bob.ReceiveCash(amount);
                    }
                    else if (whichGuy == "bob")
                    {
                        bob.GiveCash(amount);
                        joe.ReceiveCash(amount);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'joe' or 'bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit)");
                }
            }
        }
    }
}
