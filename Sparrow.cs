using System;
using System.Collections.Generic;
using mis321_pa2_brocbozeman.Interfaces;

namespace mis321_pa2_brocbozeman
{
    public class Sparrow : Character
    {
        
        public Sparrow(){
            Name = "Jack Sparrow";
            PlayerName = GetPlayerName();
            this.MaxPower = GetMaxPower();
            Health = 100;
            AttackStrength = GetAttackStrength();
            DefensivePower = GetDefensivePower();
            attackBehavior = new DistractBehavior();
        }
        
        

   

    }
}