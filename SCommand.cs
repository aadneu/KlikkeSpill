using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkeSpill
{
    public class SCommand : ICommand
    {
        public char Character { get; set; }

        public SCommand()
        {
            Character = 'S';
        }

        public void Run(ClickerGame game)
        {
            if (game.points >= 100)
            {
                game.points -= 100;
                game.pointsPerClickIncrease++;
            }
        }
    }
}

// else if (command == 'S' && points >= 100)
// {
// points -= 100;
// pointsPerClickIncrease++;
// }
