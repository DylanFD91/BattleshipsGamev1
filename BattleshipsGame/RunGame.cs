using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsGame
{
    class RunGame
    {
        //Member Variables(HAS A)
        Player player1;
        Player player2;
        public bool player1Turn = true;

        //Constructor(IS A)
        public RunGame()
        {

        }

        //Methods(CAN DO)


        
        private void BeginGame()//Game Setup(beginning of the game)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|Welcome to my version of the traditional Battleships Game!|");
            Console.WriteLine("------------------------------------------------------------");
            DisplayRules();
            Console.ReadLine();
            DisplayShips();
            Console.ReadLine();
            HowManyPlayers();
        }
        private void DisplayRules()//Displays the rules of the game along with general info
        {
            Console.WriteLine("What is Battleships? Well, Battleships is a game where 2 players duke it out with 2 game boards \n" +
                              "in some intense boat on boat combat. Players will flip a coin or choose who gets to go first in \n" +
                              "some method. After thats decided players will get to place there boats on there gameboard \n" +
                              "in a horizontal or vertical manner. After all 5 boats are placed the player going first will \n" +
                              "choose a location on there hit or miss board by declaring a letter and number on the grid. \n" +
                              "The opposing player will then declare if that shot was a hit or a miss, allowing the player \n" +
                              "who called the shot to mark there board with the respective marker. So lets get into it and \n" +
                              "sink some Battleships! Press (Enter) to Continue...");
        }
        private void DisplayShips()//Displays the ships used in the game and there slot amounts aka how many times they can be hit
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|Here is a list of the 5 ships we will be using in this game |");
            Console.WriteLine("--------------------------------------------------------------");
            string shipsGettingDisplayedIntro;
            System.Threading.Thread.Sleep(700);
            shipsGettingDisplayedIntro = "Aircraft Carrier = 5 Slots\n" +
                              "Battleship = 4 Slots\n" +
                              "Destroyer = 3 Slots\n" +
                              "Submarine = 3 Slots\n" +
                              "Patrol Boat = 2 Slots\n";
            foreach (char shipDisplayer in shipsGettingDisplayedIntro)
            {
                System.Threading.Thread.Sleep(90);
                Console.Write(shipDisplayer);
            }
            Console.WriteLine("\nPress (Enter) to Continue...");
        }
        private void HowManyPlayers()//lets user input how many players
        {
            Console.WriteLine("\n---------------------------------------------------------------------------");
            Console.WriteLine("|Now lets pick how many players there are(0 is watching 2 computers play).|");
            Console.WriteLine("---------------------------------------------------------------------------\n");
            Console.WriteLine("(Please Type 0, 1, or 2)\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    player1 = new AI();
                    player2 = new AI();
                    Console.WriteLine("\nWelcome Admiral " + player1.name + " and " + player2.name + " to Battleships! Press (Enter) to Continue...");
                    Console.ReadLine();
                    break;
                case "1":
                    player1 = new Human();
                    player2 = new AI();
                    Console.WriteLine("\nWelcome Admiral " + player1.name + " and " + player2.name + " to Battleships! Press (Enter) to Continue...");
                    Console.ReadLine();
                    break;
                case "2":
                    player1 = new Human();
                    player2 = new Human();
                    Console.WriteLine("\nWelcome Admiral " + player1.name + " and " + player2.name + " to Battleships! Press (Enter) to Continue...");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("\nThat was not a valid response, please press enter and try again.\n");
                    Console.ReadLine();
                    HowManyPlayers();
                    break;
            }
            Console.Clear();
        }
        private void DecideWhoGoesFirst()//randomly picks who gets to go first
        {

        }



        private void MidGame()//Mid Game(actually playing the game)
        {

        }
        private void PlaceShips()//allows both players to place there ships
        {

        }
        private void TurnSwitch()//declares which players turn it is
        {

        }

        private void Shotchoice()//player calls out location they want to hit
        {

        }
            private void CompareOpponentBoardToChoice()//compares user input to opponents board to see if its a hit/miss
            {

            }
            private void ConfirmAndMarkBoard()//marks the players hit/miss board showing spots they have already called
            {

            }
        private void ShipSunkChecker()//checks if the ship has been hit the required amount of times
        {

        }
            private void ShipSunk()//actually sinks the ship removing from the list
            {

            }
        private void ErrorStatement()//this is just to hold a error statement to call when needed for improper user validation.
        {

        }



        private void EndGame()//End Game(compares player boards and ship list and declares a winner)
        {

        }


        
        public void PlayGame()//Runs Game using the Begin/Mid/End game methods
        {
            BeginGame();
            MidGame();
            EndGame();
        }
    }
}
