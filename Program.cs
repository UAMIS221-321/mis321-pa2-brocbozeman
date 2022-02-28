using System;

namespace mis321_pa2_brocbozeman
{
    class Program
    {
        static void Main(string[] args)
        {
            Character playerOne = CharacterChoice.PlayerOneChoice();
            Character playerTwo = CharacterChoice.PlayerTwoChoice();
            if(playerOne == null || playerTwo == null){
                Exit();
            }
            else{
            int choice = RandomDraw.Draw();
            if(choice == 0){
                System.Console.WriteLine("{0} will be going first", playerOne.PlayerName);
                while(playerOne.Health > 0 && playerTwo.Health > 0){
                    playerOne.attackBehavior.Attack(playerOne, playerTwo);
                    if(playerOne.Health > 0 && playerTwo.Health > 0){
                        playerTwo.attackBehavior.Attack(playerTwo, playerOne);
                    }
                }
                    if(playerOne.Health < 0){
                        System.Console.WriteLine("{0} wins!" , playerTwo.PlayerName);
                    }
                    else{
                        System.Console.WriteLine("{0} wins!", playerOne.PlayerName);
                    }
               

            }
            else{
                System.Console.WriteLine("{0} will be going first", playerTwo.PlayerName);
                while(playerOne.Health > 0 && playerTwo.Health > 0){
                    playerTwo.attackBehavior.Attack(playerTwo, playerOne);
                    if(playerOne.Health > 0 && playerTwo.Health > 0){
                        playerOne.attackBehavior.Attack(playerOne, playerTwo);
                    }              
                }
                    if(playerOne.Health < 0){
                        System.Console.WriteLine("{0} wins!", playerTwo.PlayerName);
                    }
                    else{
                        System.Console.WriteLine("{0} wins!", playerOne.PlayerName);
                    }
            }
            }
        }
        public static void Exit(){
            System.Console.WriteLine("Goodbye");
        }
      
    }
}
