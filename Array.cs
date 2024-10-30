using System;

class Program
{
    static void Main()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };

        Random random = new Random();

        string sentence = "";
        int wordCount = 0;

        while (wordCount < 7)
        {
            int index = random.Next(words.Length); 
            sentence += words[index] + " "; 
            wordCount++;
        }
        Console.WriteLine("The sentence: " + sentence.Trim());
    }
}
