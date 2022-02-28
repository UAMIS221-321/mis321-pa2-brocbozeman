using System;
using mis321_pa2_brocbozeman.Interfaces;
namespace mis321_pa2_brocbozeman
{
    public class DavyJones : Character
    {
        public DavyJones(){
            Name = "Davy Jones";
            PlayerName = GetPlayerName();
            this.MaxPower = GetMaxPower();
            Health = 100;
            AttackStrength = GetAttackStrength();
            DefensivePower = GetDefensivePower();
            attackBehavior = new CannonFireBehavior();
        }
      
    }
}