using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using L5R.Cards;

namespace L5R {
    public class GameState {

        private int unitID;

        private int turnCounter;

        private L5R.Player player1;
        private L5R.Player player2;
        // We should only store one variable; otherwise it gets confusing and
        // we are forced to ensure that every change covers both
        private L5R.Player activePlayer;
        // We don't need to set the inactivePlayer directly; 
        private Player inactivePlayer {
            get {
                if (activePlayer == player1) {
                    return player2;
                }
                return player1;
            }
        }

        private string turnPhase;


        private bool gameOver;


        private const string straightenPhase = "straighten";
        private const string eventsPhase = "event";
        private const string limitedPhase = "limited";
        private const string battlePhase = "battle";
        private const string dynastyPhase = "dynasty";
        private const string endPhase = "end";


        public GameState(L5R.Player p1, L5R.Player p2) {

            this.turnCounter = 1;

            this.player1 = p1;
            this.player2 = p2;
            //place test to see who active player should be;
            this.activePlayer = p1;

            this.gameOver = false;
            this.unitID = 0;

        }


        public Player getPlayer1() {
            return this.player1;
        }

        public Player getPlayer2() {
            return this.player2;
        }

        public void incrementUnitID() {
            unitID++;
        }

        public int getUnitID() {
            return unitID;
        }

        /** Swaps active players
         */
        private void swapActivePlayer() {
            if (activePlayer == player1) {
                activePlayer = player2;
            }
            else {
                activePlayer = player1;
            }
        }


        public void gameLoop() {
            while (this.gameOver != true) {
                if (this.turnCounter != 1) { // swap who the active player is
                    swapActivePlayer();
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

        public void performStraightenPhase() {
            // "As the player whose turn it is, you straighten
            // all your bowed cards, including your Stronghold.
            // Note that 'Bamboo' Harvesters' has a trait that says
            // it will not straighten on the first turn.
            foreach (L5R.Card playerCard in activePlayer.cardsInPlay) {
                //playerCard.IsBowed = false;
                playerCard.straighten(this);
            }
            foreach (L5R.Unit playerUnits in activePlayer.unitsInPlay) {
                foreach (L5R.Card unitCard in playerUnits.getCardsInUnit()) {
                    unitCard.straighten(this);
                }

            }
            //Update windows form
        }

        public void performEventsPhase() {
            /*
             * "Starting with your leftmost province, turn its
             * card face-up if it is face-down. Then:
             * If the province is a Holding or Personality,
                  nothing happens now.
             * If it is an Event, take it out of the province.
                  The Event's effects resolve now,
                  before the province is refilled. Once an
                  Event has resolved, discard it.
             * If it is a Region, it must enter play
                  attached to the province it was revealed in.
                  Move the Region up partway in the province and
                  resolve any of its entering-play effects. When
                  you refill the province with another card,
                  leave the Region's title visible, sticking out
                  from under the card.
             * (etc.)
             * */

            // for each province card
            foreach (List<DynastyCard> province in activePlayer.cardsInProvince) {
                foreach (DynastyCard c in province) {
                    //Card.IsFaceDown = false;
                    c.turnFaceUp();
                    // Handle 'Events phase' behaviour
                    c.handleEventsPhase(this);
                }
                // TODO: bring regions into play
            }
        }

        public void performLimitedPhase() {
            // TODO: work out what to do here...
            //Set both players status to not have passed
            activePlayer.HasPassed = false;
            inactivePlayer.HasPassed = false;

            while (activePlayer.HasPassed == false && inactivePlayer.HasPassed == false) {
                activePlayer.performAction(this.turnPhase);
                inactivePlayer.performAction(this.turnPhase);
            }

        }

        public void performBattlePhase() {
            activePlayer.HasPassed = false;
            inactivePlayer.HasPassed = false;
        }

        public void performDynastyPhase() {

            // XXX: We should pull GUI stuff out of the game logic
            // straight away --- this will be a nightmare to maintain
            // otherwise
            //List<RadioButton> listOfRadioButtons = new List<RadioButton>();

            // For each province:
            //for (int i = 0; i < 4; i++) {
            // Easier to read as a foreach; you can get the index number
            // (if you really need it; e.g., for logging) with
            // int i = activePlayer.cardsInProvince.IndexOf(province)
            foreach (List<Card> province in activePlayer.cardsInProvince) {
                // TODO: if a personality card is face up, then do something
                
                //if (province[0].IsPersonality == true && province[0].IsFaceDown == false) {
                    // TODO: some game logic
                    //Console.WriteLine("Card in province " + i + " is a personality and is called: " + activePlayer.cardsInProvince[i, 0].name);
                    //RadioButton cardButton = new RadioButton();
                    //cardButton.Text = "Personality:" + activePlayer.cardsInProvince[i, 0].name + " Gold Cost:" + activePlayer.cardsInProvince[i, 0].BaseGoldCost.ToString();
                    //cardButton.Tag = i;
                    //listOfRadioButtons.Add(cardButton);
                    //Add to the list of cards that can be bought.
                //}

                // TODO: if a region card is face up, then do something

                //if (activePlayer.cardsInProvince[i, 0].IsHolding == true && activePlayer.cardsInProvince[i, 0].IsFaceDown == false) {
                    //Console.WriteLine("Card in province " + i + " is a holding and is called: " + activePlayer.cardsInProvince[i, 0].name);
                    //Add to the list of cards that can be bought.
                    // This is the card in the province activePlayer.cardsInProvince[i][0];
                    // Add to list of possible cards that can be bought.
                    RadioButton cardButton = new RadioButton();
                    //cardButton.Text = "Holding:" + activePlayer.cardsInProvince[i, 0].name + " Gold Cost:" + activePlayer.cardsInProvince[i, 0].BaseGoldCost.ToString();
                    //cardButton.Tag = i;

                    //listOfRadioButtons.Add(cardButton);
                //}
            }
            // XXX: more UI stuff
            //DynastyPopup dp = new DynastyPopup();
            //dp.CurrentPlayer = activePlayer;
            //TableLayoutPanel tl = dp.getPurchaseTableLayoutPanel();
            //tl.RowCount = 5;
            //tl.ColumnCount = 1;
            //foreach (RadioButton rb in listOfRadioButtons) {
            //    rb.Dock = DockStyle.Fill;
            //    tl.Controls.Add(rb);
            //}
            //dp.Visible = true;
            //dp.Show();
            //Console.WriteLine("Number of radio buttons created:" + listOfRadioButtons.Count.ToString());
            //Console.WriteLine("Number of controls:" + dp.Controls.Count.ToString());
        }

        public void PerformEndPhase() {
            activePlayer.cardsInHand.Add(activePlayer.cardsInFateDeck[0]);
            activePlayer.cardsInFateDeck.RemoveAt(0);

            if (activePlayer.cardsInHand.Count > activePlayer.MaxHandSize) {
                //Player Must discard down to 8 cards
            }
        }
    }
}
