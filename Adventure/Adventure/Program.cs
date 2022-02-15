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
                    Console.WriteLine("Humans....Not to great at anything, but not entirely bad either... just...mediocre\n");
                    Console.WriteLine("One handed weapon +1");
                    Console.WriteLine("Two Handed Weapons +2");
                    Console.WriteLine("Ranged Weapons +1");
                    Console.WriteLine("Magic +1");
                    Console.WriteLine("Is this mediocracy what you want YES/NO?");
                    input = Console.ReadLine().ToUpper();
                    if (input == "YES")
                    {
                    correct = 1;
                    }
                    else
                    {
                        correct = 0;
                    }
                }
                if (race == "ELF")
                {
                    Console.WriteLine("Elf, smart, witty, dexterous...thin and breaky. Great as long as you don't get hit by anything harder than a feather\n");
                   
                    Console.WriteLine("Ranged Weapons +1");
                    Console.WriteLine("Magic +1");

                    Console.WriteLine("Is this proud, narrow figure of nobility what you want? YES/NO");
                    input = Console.ReadLine().ToUpper();
                    if (input == "YES")
                    {
                        correct = 1;
                    }
                    else
                    {
                        correct = 0;
                    }
                }
                if (race == "DWARF")
                {
                    Console.WriteLine("Dwarves, the hardy race, tightly wound compact creatures of pride and furiousness....\ncan't reach anything on a shelf though.\n");

                    Console.WriteLine("One handed weapon +1");
                    Console.WriteLine("Two Handed Weapons +2");
                   
                    Console.WriteLine("Is this axe wielding demon of the caves what you want? YES/NO\n");
                    input = Console.ReadLine().ToUpper();
                    if (input == "YES")
                    {
                        correct = 1;
                    }
                    else
                    {
                        correct = 0;
                    }
                }
                    if (race == "ORC")
                {
                    Console.WriteLine("Orc, Big, brutish creatures that smash what they like and eat what they smash.\n");
                
                    Console.WriteLine("Two Handed Weapons +3");
                    ;
                   
                    Console.WriteLine("Ya, one bonus is it.... This the brtue you want? YES/NO\n ");
                    input = Console.ReadLine().ToUpper();
                    if (input == "YES")
                    {
                        correct = 1;
                    }
                    else
                    {
                        correct = 0;
                    }
                }
                if (correct != 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(300, 300);
                    Console.WriteLine("Enter a valid choice.");
                    Console.ForegroundColor = ConsoleColor.White;
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

                if (charClass == "WARRIOR")
                {
                    Console.WriteLine("The indominable warrior, a spirit that cannot be crushed and who finds any reason to fight.\n" +
                        "will find a way to attack anything with whatever is handy. Aside from that it takes no finesse to be one,\n" +
                        "no imagination, and really no desire to do anything more than yell CHAAAAAAARGE\n");
                    Console.WriteLine("Weapon bonuses:\n" +
                        "One Handed Weapons +2\n Two Handed Weapons +2");
                    Console.WriteLine("Is it a warrior then? YES/NO");
                    input = Console.ReadLine().ToUpper();
                    if (input == "YES")
                    {
                        correct = 1;
                    }
                    else
                    {
                        correct = 0;
                    }

                }
                    
                  if (charClass == "RANGER" )
                {
                    Console.WriteLine("A true force of fury and nature! At one with the wilderness and always itchy from .\n" +
                        "Poison Ivy...but hey I guess no one will try to wrestle you down knowing that.\n");
                        
                    Console.WriteLine("Weapon bonuses:\n" +
                        "One handed Weapons +2\nRanged +2 ");
                    Console.WriteLine("Shall we live in the wilderness as a ranger? YES/NO");
                    input = Console.ReadLine().ToUpper();
                    if (input == "YES")
                    {
                        correct = 1;
                    }
                    else
                    {
                        correct = 0;
                    }

                }
                if (charClass == "MAGE" )
                {
                    Console.WriteLine("Able to conjure metors out of the heavens, rend the very earth with their will\n" +
                        "reach into the nether realms to wield the dark power of death! SUCH POWER! but that comes\n" +
                        "a heavy price.. Your personality sucks... as in you don't have one. Your years in study have \n" +
                        "made you unsuitable to be in public, your just not social... sounds kinda familiar\n...yeah im" +
                        "looking at your developers....same thing...studying, by yourself...just sad... but oh the POWER!!");
                    Console.WriteLine("Weapon bonuses:\n" +
                        "Magic +3");
                    Console.WriteLine("Dare you play with such power as a mage? YES/NO");
                    input = Console.ReadLine().ToUpper();
                    if (input == "YES")
                    {
                        correct = 1;
                    }
                    else
                    {
                        correct = 0;
                    }

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
            if (charClass == "RANGER")
            {
                playerOneHanded = playerOneHanded + 2;
                playerRanged = playerRanged + 2;
            }

            //if (charClass == "THIEF")
            //{
            //    playerOneHanded = playerOneHanded + 2;
            //    playerRanged = playerRanged + 2;
            //}

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
