using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8A___Roulette
{
    class Game
    {
        public object[] number = new object[38]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
            28, 29, 30, 31, 32, 33, 34, 35, 36, "00", 0,
        };

        public string[] color = new string[38]
        {
             "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black",
            "red", "black", "red", "black", "red", "black", "red", "red", "black", "red", "black", "red", "black",
            "red", "black", "red", "black", "black", "red", "black", "red", "black", "red", "black", "red","green", "green",
        };

        Random random = new Random();
        public int[] column1 = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        public int[] column2 = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public int[] column3 = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public int[] street1 = new int[3] { 1, 2, 3 };
        public int[] street2 = new int[3] { 4, 5, 6 };
        public int[] street3 = new int[3] { 7, 8, 9 };
        public int[] street4 = new int[3] { 10, 11, 12 };
        public int[] street5 = new int[3] { 13, 14, 15 };
        public int[] street6 = new int[3] { 16, 17, 18 };
        public int[] street7 = new int[3] { 19, 20, 21 };
        public int[] street8 = new int[3] { 22, 23, 24 };
        public int[] street9 = new int[3] { 25, 26, 27 };
        public int[] street10 = new int[3] { 28, 29, 30 };
        public int[] street11 = new int[3] { 31, 32, 33 };
        public int[] street12 = new int[3] { 34, 35, 36 };

        public void Intro()
        {
            Console.WriteLine("Come on up and test your luck!");
            Console.WriteLine("Welcome to Roulette!\n\n");
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadLine();
            Console.Clear();

        }
        public int Position { get; set; }

        public int SpinPosition()
        {
            int position;
            Position = random.Next(0, 37);
            if (Position == 0)
            {
                position = (int)number[Position];
            }
            else
            {
                position = (int) number[Position - 1];
            }

            return position;
        }
        public string GetColor(string[] color)
        {
            string colorresult;
            if (Position == 0)
            {
                colorresult = color[Position];
            }
            else
            {
                colorresult = color[Position - 1];
            }

            return colorresult;
        }

        public bool Column(int[] column)
        {
            for (int i = 0; i < column.Length-1; i++)
            {
                if (column[i]== Position)
                {
                    return true;
                }
            }

            return false;
        }
        
    }
    
}
