using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsGame
{
    public abstract class Player
    {
        //Member Variables(HAS A)
        public string name;

        //Constructor(IS A)
        public Player()
        {
            EnterName();
        }

        //Methods(CAN DO)
        public abstract void EnterName();
    }
}
