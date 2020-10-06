using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dice_App.Models
{
    public class Die
    {
        Random rnd = new Random();
        List<int> dice = new List<int>();

        public List<int> Roll()
        {
            dice.Add(rnd.Next(1, 6));
            dice.Add(rnd.Next(1, 6));
            return dice;
        }

    }
}