using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace KlikkeSpill
{
    public class SpaceCommand : ICommand

    {
        public char Character { get; set; }

        public SpaceCommand()
        {
            Character = ' ';
        }
        public void Run(ClickerGame game)
        {
            game.points += game.pointsPerClick;
        }
    }
}
//  else if (command == ' ') points += pointsPerClick;
