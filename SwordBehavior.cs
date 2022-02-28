using System;
using mis321_pa2_brocbozeman.Interfaces;
namespace mis321_pa2_brocbozeman
{
    public class SwordBehavior : IAttack
    {
        public double DamageDealt;
          public void Attack(Character x, Character y){
            System.Console.WriteLine("Press any key to attack");
            Console.ReadKey();
            System.Console.WriteLine("\nTurner attacks\n");
            double a = x.GetAttackStrength();
            double b = y.GetDefensivePower();
            if(y.Name == "Davy Jones"){
                DamageDealt = (a - b)*1.2;
                System.Console.WriteLine("Attack Strength {0}\nDefense Power {1}", Math.Round(a*1.2), b);
            }
            else{
                DamageDealt = a - b;
                System.Console.WriteLine("Attack Strength {0}\nDefense Power {1}", a, b);
            }
            if(DamageDealt < 0){
                DamageDealt = 0;
            }
            System.Console.WriteLine("\nDamage Dealt: " + Math.Round(DamageDealt));
            y.Health -= DamageDealt;
            if(y.Health < 1){
                System.Console.WriteLine(y.Name + " dies");
            }
            else{
                System.Console.WriteLine("\n{0} Health: {1}\n", y.Name, Math.Round(y.Health));
            }
            
            
        }
    }
    
}