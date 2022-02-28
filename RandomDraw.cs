using System;
namespace mis321_pa2_brocbozeman
{
    public class RandomDraw
    {
        public static int Draw(){
            Random myRandom = new Random();
            int choice = myRandom.Next(2);
            return choice;
        }
    }
}