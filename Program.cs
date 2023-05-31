using System;

namespace UnderstandingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomSuit = random.Next(4);
            int randomValue = random.Next(1, 14);

            Card myCard = new Card((Values)randomValue, (Suits)randomSuit);
            Console.WriteLine(myCard.Name);
        }
    }
}
