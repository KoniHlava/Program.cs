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
            List<Hrac> listOfPlayers = new List<Hrac>();
            char LastChar;
            string name;
            int age;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Napiš jméno hráče: ");
                name = Console.ReadLine();
                Console.WriteLine("Napiš věk hráče: ");
                age = int.Parse(Console.ReadLine());
                Hrac player = new Hrac(name, age);
                listOfPlayers.Add(player);
            }

            Console.Write("Zadej první slovo: ");

            string FirstPlayer;

            do
            {
                FirstPlayer = Console.ReadLine();
                LastLetterINTFE = FirstPlayer.Length - 1;
                LastLetterCHARFE = FirstPlayer[LastLetterINTFE];
                Console.WriteLine("Nyní hraje, " + listOfPlayers[0].getName() + " a musí zadat slovo které začíná na: " + LastLetterCHARFE); ;
                string SecondPlayer = Console.ReadLine();
                LastLetterINTSE = SecondPlayer.Length - 1;
                LastLetterCHARSE = SecondPlayer[LastLetterINTSE];
                FirstLetterCHARSE = SecondPlayer[0];
                Console.WriteLine("Nyní hraje, " + listOfPlayers[1].getName() + " a musí zadat slovo které začíná na: " + LastLetterCHARSE);
                Console.WriteLine("Právě probíhá kolo " + Hrac.getRound());
                LastChar = SecondPlayer[SecondPlayer.Length - 1];
            } while ((FirstPlayer[0] == LastChar));

        }
    }







}
