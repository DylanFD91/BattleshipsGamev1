using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsGame
{
    class AI : Player
    {
        //Member Variables(HAS A)

        //Constructor(IS A)
        public AI()
        {

        }

        //Methods(CAN DO)
        public override void EnterName()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Please enter your name Admiral: ");
            Console.WriteLine("----------------------------------\n");
            string input = Console.ReadLine();
            name = input;
        }
        public override void CallOutShotLocation()
        {

        }
    }
}
