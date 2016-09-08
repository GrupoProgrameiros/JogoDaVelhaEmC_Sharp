using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Play
{
    class Program
    {
        static string[] vetorPosition = new string[] { "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   " };
        static void Main(string[] args)
        {
            DesenharJogo();
            int position;
            bool hasPosition = true;
            string log = "O";
            while (hasPosition)
            {
                if (log[log.Length - 1].ToString().Contains("O"))
                {
                    Console.WriteLine("Digite a posição {1 - 9} que queira colocar o X");
                    string str = Console.ReadLine();

                    if (int.TryParse(str, out position))
                    {
                        log += (vetorPosition[position - 1] = " X ")[1];
                    }
                }
                else
                {
                    Console.WriteLine("Digite a posição {1 - 9} que queira colocar o O");
                    string str = Console.ReadLine();

                    if (int.TryParse(str, out position))
                    {
                        log += (vetorPosition[position - 1] = " O ")[1];
                    }
                }

                DesenharJogo();

                if (vetorPosition.Count(p => p == "   ") > 0)
                    hasPosition = true;
                else
                    hasPosition = false;
            }
            Console.WriteLine("Acabou <o>");
            Console.ReadKey();
        }

        private static void DesenharJogo()
        {
            Console.Clear();
            Console.WriteLine
                (
                    @"




                              |                  |
                              |                  |
                      {0}     |       {1}        |      {2}
                              |                  |
                  ----------------------------------------------            
                              |                  |
                              |                  |
                      {3}     |       {4}        |      {5}
                              |                  |
                  ----------------------------------------------           
                              |                  |
                      {6}     |       {7}        |      {8}
                              |                  |
                              |                  |
                    ",
                     vetorPosition[0], vetorPosition[1], vetorPosition[2], vetorPosition[3], vetorPosition[4], vetorPosition[5], vetorPosition[6], vetorPosition[7], vetorPosition[8]
                );
        }
    }
}
