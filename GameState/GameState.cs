using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.GameState
{
    class GameState
    {
        
        private int turnCounter;

        private L5R.Player player1;
        private L5R.Player player2;
        private L5R.Player activePlayer;

        private string turnPhase;


        private bool gameOver;


        private const string straightenPhase = "straighten";
        private const string eventsPhase = "event";
        private const string limitedPhase = "limited";
        private const string battlePhase = "battle";
        private const string dynastyPhase = "dynasty";
        private const string endPhase = "end";
        
        
        public GameState(L5R.Player p1,L5R.Player p2)
        {
       
            this.turnCounter = 1;

            this.player1 = p1;
            this.player2 = p2;
            //place test to see who active player should be;
            this.activePlayer = p1;
            

            this.gameOver = false;

        }


        public Player getPlayer1()
        {
            return this.player1;
        }

        public Player getPlayer2()
        {
            return this.player2;
        }
       
        public void gameLoop()
        {
            while(this.gameOver!=true)
            {
                if (this.turnCounter != 1)
                { // swap who the active player is
                    if (player1.getIsActivePlayer() == true)
                    {
                        this.player1.setAsInactivePlayer();
                        this.player2.setAsActivePlayer();
                        this.activePlayer = player2;
                    }
                    else
                    {
                        this.player2.setAsInactivePlayer();
                        this.player1.setAsActivePlayer();
                        this.activePlayer = player1;
                    }
                }

                // perform straighten phase
                this.performStraightenPhase();
                this.turnPhase = eventsPhase;
                
                // perform events phase
                this.performEventsPhase();
                this.turnPhase = limitedPhase;
                
                //perform limited phase
                this.performLimitedPhase();
                this.turnPhase = battlePhase;
                
                //perform optional battle phase
                this.performBattlePhase();
                this.turnPhase = dynastyPhase;
                
                //perform dynasty phase
                this.performDynastyPhase();
                this.turnPhase = endPhase;
                
                //perform end phase
                this.performEventsPhase();
                this.turnPhase = straightenPhase;

                this.turnCounter++;
                
            }
        }

        public void performStraightenPhase()
        { }

        public void performEventsPhase()
        { }

        public void performLimitedPhase()
        { }

        public void performBattlePhase()
        { }

        public void performDynastyPhase()
        { }

        public void PerformEndPhase()
        { }        
    }
}
