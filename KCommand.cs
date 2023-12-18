using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkeSpill
{
    public class KCommand : ICommand
    {
        public char Character { get; set; }

        public KCommand()
        {
            Character = 'K';
        }

        public void Run(ClickerGame game)
        {
            if (game.points >= 10)
            {
                game.points -= 10;
                game.pointsPerClick += game.pointsPerClickIncrease;
            };
        }
    }
}

//else if (command == 'K' && points >= 10)
// {
// points -= 10;
// pointsPerClick += pointsPerClickIncrease;
// }
