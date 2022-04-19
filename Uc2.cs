using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    public class Uc2:Uc1
    {
        public int RollingDice()
        {
            Random roll = new();
            int rolled = roll.Next(1, 7);
            Console.WriteLine(rolled);
            return rolled;
        }
    }
}
