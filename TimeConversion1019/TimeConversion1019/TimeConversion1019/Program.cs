using System;
class URI
{

    static void Main(string[] args)
    {
        int time = 0;
        int timeinsec = 0;
        int timeinmin = 0;
        int timeinhr = 0;

        int timeinminaux = 0;
        Console.Write("Insira o tempo em segundos: ");
        time = int.Parse(Console.ReadLine());
        
        while (time % 60 != 0)
        {
            time = time - 1;
            timeinsec = timeinsec + 1;
        }

        timeinminaux = (time / 60);
        time = 0;

        while (timeinminaux % 60 != 0)
        {

            timeinminaux = timeinminaux - 1;
            timeinmin = timeinmin + 1;

        }
        timeinhr = (timeinminaux / 60);
        time = 0;
        Console.WriteLine(timeinhr + ":" + timeinmin + ":" + timeinsec);

    }
}