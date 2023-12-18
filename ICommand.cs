using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkeSpill
{
    public interface ICommand
    {
        
        public char Character { get; set; }

        

       
       void Run( ClickerGame game);
    }
}
