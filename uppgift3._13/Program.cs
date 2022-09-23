using System;
    namespace Uppgift3._13
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hur gammal är du, svara i hela årtal");

            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16 && ålder <= 19)
            {
                Console.WriteLine("Du får vara med i tävlingen");
            }

            if (ålder < 16)
            {
                Console.WriteLine("Du är för ung för att vara med i tävlingen");
            }

            if(ålder > 19)
            {
                Console.WriteLine("Du är för gammal för att vara med i tävlingen");
            }
        }
    }
}

