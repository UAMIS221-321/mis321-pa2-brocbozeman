
using System;
namespace mis321_pa2_brocbozeman
{
    public class CharacterChoice
    {
        public static Character PlayerOneChoice(){
            bool run = true;
            int userChoice = 0;
            while(run == true){
            System.Console.WriteLine("Player 1: Please select a character \n 1. Jack Sparrow \n 2. Will Turner \n 3. Davy Jones\n 4. Exit");
            try{
                userChoice = int.Parse(Console.ReadLine());
                run = false;
            }
            catch{
                System.Console.WriteLine("Invalid response");
            }
            }
            run = true;
            System.Console.WriteLine("Player 1:");
            switch(userChoice){
                case 1: 
                Character SparrowOne = new Sparrow();
                return SparrowOne;
                case 2: 
                Character TurnerOne = new Turner();
                return TurnerOne;
                case 3:
                Character JonesOne = new DavyJones();
                return JonesOne;
                default:
                System.Console.WriteLine("Please enter '4' for your Player 2 response to exit.");
                return null;
            }
        }
            public static Character PlayerTwoChoice(){
            System.Console.WriteLine("Player 2: Please select a character \n 1. Jack Sparrow \n 2. Will Turner \n 3. Davy Jones\n 4. Exit");
            int userChoice = 0;
            try{
                userChoice = int.Parse(Console.ReadLine());
            }
            catch{
                System.Console.WriteLine("Invalid response");
            }
            System.Console.WriteLine("Player 2:");
            switch(userChoice){
                case 1: 
                Character SparrowTwo = new Sparrow();
                return SparrowTwo;
                case 2: 
                Character TurnerTwo = new Turner();
                return TurnerTwo;
                case 3:
                Character JonesTwo = new DavyJones();
                return JonesTwo;
                default:
                return null;
            }
            
        }
    
    }
}