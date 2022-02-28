using System.Runtime.CompilerServices;
using System;
using mis321_pa2_brocbozeman.Interfaces;
namespace mis321_pa2_brocbozeman
{
    public class Character 
    {
        public string Name{get;set;}
        public string PlayerName{get;set;}
        public int MaxPower{get;set;}
        public double Health{get;set;}
        public int AttackStrength{get;set;}
        public int DefensivePower{get;set;}

        public IAttack attackBehavior {get; set;}
  
        public string GetPlayerName(){
            System.Console.WriteLine("Please enter your name");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("Welcome {0}! You will be playing as {1}", PlayerName, Name);
            return PlayerName;
        }
        public int GetMaxPower(){
            Random random = new Random();
            int MaxPower = random.Next(100) + 1;
            return MaxPower;
        }
        public int GetAttackStrength(){
            Random random = new Random();
            int AttackStrength = random.Next(MaxPower) + 1;
            return AttackStrength;
        }
        public int GetDefensivePower(){
            Random random = new Random();
            int DefensivePower = random.Next(MaxPower) + 1;
            return DefensivePower;    
        }

        
    }
}