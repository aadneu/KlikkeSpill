using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkeSpill
{
    public class ClickerGame
    {
       public int points { get; set; }
       public int pointsPerClick { get; set; }
       public int pointsPerClickIncrease { get; set; }

       public ClickerGame()
       {
           points = 0;
           pointsPerClick = 1;
           pointsPerClickIncrease = 1;
       }
        
    }

    
}
