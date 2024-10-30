using System;

class NumberGenerator
{
    static void Main()
    {
        Random random = new Random();
        int number;

        while (true)
        {
            number = random.Next(1, 21); 

            if (number == 5)
            {
                continue; 
            }

            Console.WriteLine("Random number: " + number);

            if (number == 15)
            {
                break;
            }
        }
    }
}
