using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovniFotbal
{
    class Program
    {
        static void Main(string[] args)
        {
            int LastLetterINTFE = 0;
            int LastLetterINTSE = 0;
            char LastLetterCHARFE;
            char LastLetterCHARSE;
            char FirstLetterCHARSE;
            Hrac Player1 = new Hrac("XXX", 0);
            Hrac Player2 = new Hrac("XXX", 0);
            Console.Write("Zadej první slovo: ");

            while (true)
            {
                string FirstPlayer = Console.ReadLine();
                LastLetterINTFE = FirstPlayer.Length - 1;
                LastLetterCHARFE = FirstPlayer[LastLetterINTFE];
                Console.WriteLine("Nyní hraje, " + Player1.WriteName() + " a musí zadat slovo které začíná na: " + LastLetterCHARFE); ;
                string SecondPlayer = Console.ReadLine();
                LastLetterINTSE = SecondPlayer.Length - 1;
                LastLetterCHARSE = SecondPlayer[LastLetterINTSE];
                FirstLetterCHARSE = SecondPlayer[0];
                Console.WriteLine("Nyní hraje, " + Player2.WriteName() + " a musí zadat slovo které začíná na: " + LastLetterCHARSE);
                Console.WriteLine("Právě probíhá kolo " + Player1.getRound());
            }

        }
    }







}
