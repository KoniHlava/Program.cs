using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovniFotbal
{
    class Hrac
    {
        private static int round = 0;
        private string name;
        private int age;
        private int points;

        public Hrac(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public void setName(string name)
        {
            //Console.Write("Napiš jméno hráče: ");
            //name = Console.ReadLine();
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            //Console.Write("Napiš věk hráče: ");
            //age = int.Parse(Console.ReadLine());
            return age;
        }

        public void setAge(int age)
        {
            //Console.Write("Napiš věk hráče: ");
            //age = int.Parse(Console.ReadLine());
            this.age = age;

        }

        public static int getRound()
        {
            return round;
        }

        public static void setRound()
        {
            round++;
        }


        public int getPoints()
        {
            return points;
        }

        public void setPoints()
        {
            this.points = points++;
        }

    }
}
