using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkeSpill
{
    public class XCommand : ICommand
    {
        public char Character { get; set; }

        public XCommand()
        {
            Character = 'X';
        }

        public void Run(ClickerGame game)
        {
            Environment.Exit(0);
        }
    }
}

//  if (command == 'X') Environment.Exit(0);
