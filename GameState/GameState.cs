using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L5R.GameState
{
    class GameState
    {

        private int unitID;

        private int turnCounter;

        private L5R.Player player1;
        private L5R.Player player2;
        private L5R.Player activePlayer;
        private L5R.Player nonActivePlayer;

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
            this.nonActivePlayer = p2;
            

            this.gameOver = false;
            this.unitID = 0;

        }


        public Player getPlayer1()
        {
            return this.player1;
        }

        public Player getPlayer2()
        {
            return this.player2;
        }

        public void incrementUnitID()
        {
            unitID++;
        }

        public int getUnitID()
        {
            return unitID;
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
                        this.nonActivePlayer = player1;
                    }
                    else
                    {
                        this.player2.setAsInactivePlayer();
                        this.player1.setAsActivePlayer();
                        this.activePlayer = player1;
                        this.nonActivePlayer = player2;
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
        { 
            foreach(L5R.Card playerCard in activePlayer.getCardsInPlay())
            {
                playerCard.IsBowed = false;
            }

            foreach (L5R.Unit playerUnits in activePlayer.getUnitsInPlay())
            {
                foreach (L5R.Card playersUnitCard in playerUnits.getCardsInUnit())
                {
                    playersUnitCard.IsBowed = false;
                }
            
            }

           
            

            //Update windows form
        }

        public void performEventsPhase()
        {
            foreach (var provence in activePlayer.getCardsInProvence())
            {
                foreach (L5R.Card cardinProvence in provence)
                {
                    cardinProvence.IsFaceDown = false;

                    if (cardinProvence.IsRegion == true)
                    {   //bring regionIntoPlay
                    }
                }
            }

          
        }

        public void performLimitedPhase()
        {
            //Set both players status to not have passed
            activePlayer.HasPassed = false;
            nonActivePlayer.HasPassed = false;
            
            while (activePlayer.HasPassed == false && nonActivePlayer.HasPassed == false)
            {
                activePlayer.performAction(this.turnPhase);
                nonActivePlayer.performAction(this.turnPhase);
            }

        }

        public void performBattlePhase()
        {
            activePlayer.HasPassed = false;
            nonActivePlayer.HasPassed = false; 
        }

        public void performDynastyPhase()
        {

            List<RadioButton> listOfRadioButtons = new List<RadioButton>();
            int i=0;
            foreach (List<L5R.Card> cardInProvence in activePlayer.getCardsInProvence())
            {
                Console.WriteLine("Iterations of provences:" + i.ToString());

                if (cardInProvence[0].IsPersonality == true && cardInProvence[0].IsFaceDown == false)
                {
                    Console.WriteLine("Card in provence " + i + " is a personality and is called: " + cardInProvence[0].CardName);
                    RadioButton cardButton = new RadioButton();
                    cardButton.Text = "Personality:" + cardInProvence[0].CardName + " Gold Cost:" + cardInProvence[0].BaseGoldCost.ToString();
                    cardButton.Tag = i;

                    listOfRadioButtons.Add(cardButton);


                    //Add to the list of cards that can be bought.
                }

                if (cardInProvence[0].IsHolding == true && cardInProvence[0].IsFaceDown == false)
                {
                    Console.WriteLine("Card in provence " + i + " is a holding and is called: " + cardInProvence[0].CardName);
                    //Add to the list of cards that can be bought.
                    // This is the card in the provence activePlayer.getCardsInProvence()[i][0];
                    // Add to list of possible cards that can be bought.
                    RadioButton cardButton = new RadioButton();
                    cardButton.Text = "Holding:" + cardInProvence[0].CardName + " Gold Cost:" + cardInProvence[0].BaseGoldCost.ToString();
                    cardButton.Tag = i;

                    listOfRadioButtons.Add(cardButton);

                }

              

                

                i++;
            }

            DynastyPopup dp=new DynastyPopup();
            dp.CurrentPlayer = activePlayer;


            TableLayoutPanel tl = dp.getPurchaseTableLayoutPanel();
            tl.RowCount = 5;
            tl.ColumnCount = 1;

            foreach (RadioButton rb in listOfRadioButtons)
            {
                rb.Dock = DockStyle.Fill;
                tl.Controls.Add(rb);
                

                
            }

            
            dp.Visible = true;
            dp.Show();

            Console.WriteLine("Number of radio buttons created:" + listOfRadioButtons.Count.ToString());
            Console.WriteLine("Number of controls:"+dp.Controls.Count.ToString());
           
            
        
        }

        public void PerformEndPhase()
        {
            activePlayer.getCardsInHand().Add(activePlayer.getCardsInFateDeck()[0]);
            activePlayer.getCardsInFateDeck().RemoveAt(0);

            if (activePlayer.getCardsInHand().Count > activePlayer.MaxHandSize)
            {
                //Player Must discard down to 8 cards
            }
        }        
    }
}
