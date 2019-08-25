using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8A___Roulette
{
    class Player
    {
        Game game = new Game();
        public double Balance { get; set; }
        public int Turn { get; set; }
        public double Userbet { get; set; }
        public void PlayerStat(double Balance, int Turn)
        {
            this.Balance = Balance;
            this.Turn = Turn;
            this.Userbet = Userbet;
        }
        public void Start()
        {
            //creating a do while loop can keep the text displayed throughout the whole game
            PlayerStat(1000, 1);
            game.Intro();
            do
            {
                Console.Clear();
                Console.WriteLine("               ╔>═>═>═>═>═>═>═>═>═>═>═>═>═╗                   ");
                Console.WriteLine($"               %      Balance: {Balance}       %  ");
                Console.WriteLine("               ╚<═<═<═<═<═<═<═<═<═<═<═<═<═╝");
                Console.WriteLine("");
                Console.WriteLine("                    What is your bet?");
                Console.WriteLine("");
                Console.WriteLine("     ╔>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═>═╗                           ");
                Console.WriteLine("     %      1. Numbers    2. Even/Odd   3. Red/Black    %                            ");
                Console.WriteLine("     %      4. Low/High   5. Dozen      6. Column       %                             ");
                Console.WriteLine("     %      7. Street     8. 6 Number   9. Split        %                              ");
                Console.WriteLine("     %           10. Corner    11. End Game             %                             ");
                Console.WriteLine("     ╚<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═<═╝                              ");
                Console.WriteLine("");
                Console.Write("---->");
                string userchoice = Console.ReadLine();
                Choice(userchoice);

            }
            while (Balance <= 0);


            EndLose();
            
        }
        public void EndLose()
        {
            Console.WriteLine("You have ran out of money. Better luck next time!");
        }
        public void End()
        {
            Console.WriteLine($"You have left the game with ${Balance}");
        }
        public void Choice(string userchoice)
        {
            try
            {
                switch (userchoice)
                {
                    case "1":
                        //number
                        BetCheck();
                        Console.WriteLine("What number are you betting on?");
                        break;
                    case "2":
                        //Even odd
                        BetCheck();
                        break;
                    case "3":
                        //red or black
                        BetCheck();
                        break;
                    case "4":
                        //
                        BetCheck();
                        break;
                    case "5":
                        //
                        BetCheck();
                        break;
                    case "6":
                        //
                        BetCheck();
                        break;
                    case "7":
                        //
                        BetCheck();
                        break;
                    case "8":
                        //
                        BetCheck();
                        break;
                    case "9":
                        //
                        BetCheck();
                        break;
                    case "10":
                        //
                        break;
                    case "11":
                        End();
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
        public void BetCheck()
        {
            try
            {
                Console.WriteLine("How much do you want to bet?");
                Console.Write("---->");
                Userbet = Convert.ToInt32(Console.ReadLine());
                while (Userbet > Balance )
                {
                    Console.WriteLine("You cannot bet more than you have!");
                    Console.WriteLine("Place your bet again...");
                    Console.Write("--->");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Lostbet()
        {
            Balance -= Userbet;
                
                Console.WriteLine($"Luck is not on your side! Your balance is now ${Balance}");
                Console.WriteLine("Press enter...");
                if (Balance <= 0)
                {
                    EndLose();
                }
            
        }

    }
}
