using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkeSpill
{
    internal class CommandSet
    {
     
        private ICommand[] CommandArrays { get;  set; }

        public CommandSet()
        {
            CommandArrays = new ICommand[]
            {
                new SpaceCommand(),
                new KCommand(),
                new SCommand(),
                new XCommand(),
            };
        }

        public void RunCommand(char commandKey, ClickerGame game)
        {
            foreach (var commandClass in CommandArrays)
            {
                if (commandKey == commandClass.Character)
                {
                    commandClass.Run(game);
                    break;
                } 
            }
        }
    }
}
