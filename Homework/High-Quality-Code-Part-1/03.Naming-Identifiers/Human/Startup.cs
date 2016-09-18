namespace Human
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var magicNumber = int.Parse(Console.ReadLine());
            var human = Human.GenerateRandomHuman(magicNumber);

            Console.WriteLine($"Hello, I am {human.Name}, I am a {human.Age} years old and am a {human.Gender}!");
        }
    }
}