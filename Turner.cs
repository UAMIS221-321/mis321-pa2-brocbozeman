using System;
using mis321_pa2_brocbozeman.Interfaces;
namespace mis321_pa2_brocbozeman
{
    public class Turner : Character
    {
        public Turner(){
            Name = "Will Turner";
            PlayerName = GetPlayerName();
            MaxPower = GetMaxPower();
            Health = 100;
            AttackStrength = GetAttackStrength();
            DefensivePower = GetDefensivePower();
            attackBehavior = new SwordBehavior();
        }
    }
}