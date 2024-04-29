using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleMageADV
{   public class Game 
    {
       static string CharacterName = "";
       static string Input = "";

        public static void StartGame()
        {



            Console.Title = "ASCII Art";

            string title = @"

                                                                                            
                                                                                            
________                          ___                ___       ___                          
`MMMMMMMb.                        `MM                `MMb     dMM'                          
 MM    `Mb           /      /      MM                 MMM.   ,PMM                           
 MM     MM    ___   /M     /M      MM   ____          M`Mb   d'MM    ___     __      ____   
 MM    .M9  6MMMMb /MMMMM /MMMMM   MM  6MMMMb         M YM. ,P MM  6MMMMb   6MMbMMM 6MMMMb  
 MMMMMMM(  8M'  `Mb MM     MM      MM 6M'  `Mb        M `Mb d' MM 8M'  `Mb 6M'`Mb  6M'  `Mb 
 MM    `Mb     ,oMM MM     MM      MM MM    MM        M  YM.P  MM     ,oMM MM  MM  MM    MM 
 MM     MM ,6MM9'MM MM     MM      MM MMMMMMMM        M  `Mb'  MM ,6MM9'MM YM.,M9  MMMMMMMM 
 MM     MM MM'   MM MM     MM      MM MM              M   YP   MM MM'   MM  YMM9   MM       
 MM    .M9 MM.  ,MM YM.  , YM.  ,  MM YM    d9        M   `'   MM MM.  ,MM (M      YM    d9 
_MMMMMMM9' `YMMM9'Yb.YMMM9  YMMM9 _MM_ YMMMM9        _M_      _MM_`YMMM9'Yb.YMMMMb. YMMMM9  
                                                                           6M    Yb         
                                                                           YM.   d9         
                                                                            YMMMM9          


 ";


            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write(title);

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("\nPress Enter to Continue... ");

            Console.ReadKey();

            Console.Clear();

            Console.ResetColor();

            NameCharacter();
            Choice();
            
        }
        static void NameCharacter()
        {

            Console.WriteLine("What will you name your character? ");

            CharacterName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Your new mage will be {CharacterName} ");

            Console.ReadKey();

            Console.ResetColor();
        }

        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Choice()
        {
            //string dialogue = "";
            string input = "";
            Console.WriteLine(" What path will you choose A or B");

            input = Console.ReadLine().ToUpper();

            if (input == "A")
            {
                Console.WriteLine(CharacterName + " you have choosen A");
                Console.WriteLine(Dialogue.PartOne[0]);
            } 
            else
            {
                Console.WriteLine(CharacterName + " you have choose B ");
                Console.WriteLine(Dialogue.PartOne[3]);

            }
            Console.WriteLine("you come to path two will choose C or D ");

            Console.ReadLine().ToUpper();

            if (input == "C")
            {
                Console.WriteLine(CharacterName + "you have choosen path C");
                Console.WriteLine(Dialogue.PartOne[1]);

            }
            else 
            {
                Console.WriteLine(CharacterName + " you have choose path D");
                Console.WriteLine(Dialogue.PartOne[2]);
            }
            

        }
    }

    internal class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
            

        }
    }
}
