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
        public List<Ship> shipsList;
        public List<GameBoard> gameBoards;

        //Constructor(IS A)
        public Player()
        {
            EnterName();
            shipsList = new List<Ship>() {new PatrolBoat(), new Submarine(), new Destroyer(), new Battleship(), new AircraftCarrier()};
            gameBoards = new List<GameBoard>() {new ShipsPlacedBoard(), new HitandMissBoard()};
        }
    

        //Methods(CAN DO)
        public abstract void EnterName();
        public abstract void CallOutShotLocation();
    }
}
