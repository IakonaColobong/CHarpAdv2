using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CHARACTER CREATION - Variables
            int correct = 0;
            int playerOneHanded = 0;
            int playerTwoHanded = 0;
            int playerMagic = 0;
            int playerRanged = 0;
            int Arraycount = 0;
            
            string gender;
            string race;
            string charClass;
            string[] Inventory = new string[20];
            string input;


            //Character creation - Gender Selecion
            do
            {
                Console.WriteLine("Please choose a gender");
                Console.WriteLine("Male / Female");
                gender = Console.ReadLine().ToUpper();
                if (gender == "MALE")
                {
                    correct = 1;
                }
                if (gender == "FEMALE")
                {
                    correct = 1;
                }
                else
                {
                    if (correct !=1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Beep(300, 300);
                        Console.WriteLine("Enter a valid choice.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                   
                }
            } while (correct == 0);
            correct = 0;


            //CHARACTER CREATION - Race Selection
            do
            {
                Console.Clear();
                Console.WriteLine("Choose your race!");
                Console.WriteLine("Human ");
                Console.WriteLine("Elf");
                Console.WriteLine("Dwarf ");
                Console.WriteLine("Orc ");
                Console.WriteLine("Make your choice: ");
                race = Console.ReadLine().ToUpper();
                if (race == "HUMAN")
                {
                    correct = 1;
                }
                if (race == "ELF")
                {
                    correct = 1;
                }
                if (race == "DWARF")
                {
                    correct = 1;
                }
                if (race == "ORC")
                {
                    correct = 1;
                }
                if (correct != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(300, 300);
                    Console.WriteLine("Enter a valid choice.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {

                }

            } while (correct == 0);
            correct = 0;


            //CHARACTER CREATION - Class Selection
            do
            {
                Console.Clear();
                Console.WriteLine("Now chose your profession!");
                Console.WriteLine("Warrior");
                Console.WriteLine("Ranger");
                Console.WriteLine("Mage");
                Console.WriteLine("Your choice: ");
                charClass = Console.ReadLine().ToUpper();

                if (charClass == "WARRIOR" )
                {
                    correct = 1;
                }  if (charClass == "RANGER" )
                {
                    correct = 1;
                }  if (charClass == "MAGE" )
                {
                    correct = 1;
                }
                if (correct != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(300, 300);
                    Console.WriteLine("Enter a valid choice.");
                    Console.ForegroundColor = ConsoleColor.White;
                }


                else
                {
                   
                }
              
            } while (correct == 0);
            correct = 0;

            //CHARACTER CREATION - Race Modifiers

            if (race == "HUMAN")
            {
                playerOneHanded ++;
                playerTwoHanded ++;
                playerMagic ++;
                playerRanged ++;
            }
            if (race == "ELF")
            {
              
                playerMagic = playerMagic +2;
                playerRanged = playerRanged +2;
            }
            if (race == "DWARF")
            {
                playerOneHanded = playerOneHanded +2;
                playerTwoHanded = playerTwoHanded +2;
               
            }
            if (race == "ORC")
            {
                
                playerTwoHanded = playerTwoHanded +3;
               
            }


            //CHARACTER CREATION - Profession Modifiers

            if (charClass == "WARRIOR")
            {
                playerOneHanded = playerOneHanded +2;
                playerTwoHanded = playerTwoHanded + 2;
               
            }

            if (charClass == "THIEF")
            {
                playerOneHanded = playerOneHanded + 2;
                playerRanged = playerRanged + 2;
            }

            if (charClass == "MAGE")
            {
                playerMagic = playerMagic + 3;
            }
            //end Class Bonuses


            //INVENTORY
            Inventory[0] = "Arrows"; Inventory[1] = "Water"; Inventory[2] = "Cheese";
            Console.WriteLine("INVENTORY TEST: Type Inventory Below");
            input = Console.ReadLine().ToUpper();
            if (input == "INVENTORY")
            {
                Console.Clear();
                Console.WriteLine("Your inventory contains: ");
                
                for (Arraycount = 0; Arraycount <= 19; Arraycount++)
                {
                    
                    Console.SetCursorPosition(0, Arraycount);
                    Console.WriteLine("\n {0}", Inventory[Arraycount]);
                }
            }
            else
            {

            }
            Console.ReadLine();






        }//END VOID METHOD
    }//END CLASS
}// END NAMESPACE
