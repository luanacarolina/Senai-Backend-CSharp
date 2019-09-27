using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeDataAtual();
        }
        static void ImprimeDataAtual(){
            Console.WriteLine(DateTime.Now.DayOfWeek);

        }
    }
}
