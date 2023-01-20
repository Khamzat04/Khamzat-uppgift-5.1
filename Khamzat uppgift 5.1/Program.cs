using System;
namespace Projekt_5._1_khamzat
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("skriv in 5 olika namn på vad som helst");
            Console.WriteLine("Börja med nummer fem sedan skriv 5 namn");
            int allt = int.Parse(Console.ReadLine());
            string[] namn = new string[5];

            for (int i = 0; i < 5; i++)
            {                           
                namn[i] = Console.ReadLine();
            }
            // skriver ner allt som användare skrev.
            Console.WriteLine("Här är 5 namn du valde");
            for (int i = 0; i < allt; i++)
            {
                Console.WriteLine(namn[i]);

            }












        }

    }


}
