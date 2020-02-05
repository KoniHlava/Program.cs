using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovniFotbal
{
    class Hrac
    {
        private int round = 0;
        private string name;
        private int age;
        private int points;

        public Hrac(string name, int age)
        {
            this.name = getName();
            this.age = getAge();

        }

        public string getName()
        {
            Console.Write("Napiš jméno hráče: ");
            name = Console.ReadLine();
            return name;
        }
        public string WriteName()
        {
            return name;
        }
        public int getAge()
        {
            Console.Write("Napiš věk hráče: ");
            age = int.Parse(Console.ReadLine());
            return age;
        }

        public int getRound()
        {
            round++;
            return round;
        }
        public int getPoints()
        {
            points++;
            return points;
        }



    }
}
