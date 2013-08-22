using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using L5R.Cards;

namespace L5R {
    public class Player {
        private bool playerPerformingAction;
        private bool hasPassed;
        //private List<L5R.Unit> unitsInPlay;

        private int maxHandSize;
        private int goldPool;
        private L5R.PlayArea thePlayArea;

        public Player(List<DynastyCard> dd, List<FateCard> fd) {
            this.playerPerformingAction = false;
            this.cardsInPlay = new List<Card>();
            this.cardsInHand = new List<Card>();
            this.cardsInDynastyDiscard = new List<DynastyCard>();
            this.cardsInFateDiscard = new List<FateCard>();
            this.cardsInDynastyDeck = dd;
            this.cardsInFateDeck = fd;
            this.unitsInPlay = new List<Unit>();
            this.maxHandSize = 8;
            //this.cardsInProvince = new L5R.Card[4, 2];
            this.cardsInProvince = new List<List<DynastyCard>>(4);

            // Console.WriteLine("In Player Class Constructor. Num of Provences is:" + this.cardsInProvince.GetLength(0));
            Console.WriteLine("In Player Class Constructor. Num of Provinces is:" + this.cardsInProvince.Count);
        }


        public L5R.PlayArea ThePlayArea {
            get {
                return thePlayArea;
            }
            set {
                thePlayArea = value;
            }
        }

        public int GoldPool {
            get {
                return goldPool;
            }
            set {
                goldPool = value;
            }
        }



        public int MaxHandSize {
            get {
                return maxHandSize;
            }
            set {
                maxHandSize = value;
            }
        }


        public bool HasPassed {
            get {
                return this.hasPassed;
            }
            set {
                this.hasPassed = value;
            }
        }

        public bool getPlayerPerformingAction() {
            return this.playerPerformingAction;
        }

        public void setPlayerPerformingAction(bool isPerforming) {
            this.playerPerformingAction = isPerforming;
        }

        /*********************************************************************
         * Card lists (in play; in hand; discards; etc.)
         *********************************************************************/
        
        public List<Card> cardsInPlay {
            get;
            set;
        }

        public List<Card> cardsInHand {
            get;
            set;
        }

        public List<DynastyCard> cardsInDynastyDeck {
            get;
            set;
        }

        public List<DynastyCard> cardsInDynastyDiscard {
            get;
            set;
        }

        public List<FateCard> cardsInFateDeck {
            get;
            set;
        }

        public List<FateCard> cardsInFateDiscard {
            get;
            set;
        }

        public List<List<DynastyCard>> cardsInProvince {
            get;
            set;
        }

        public List<Unit> unitsInPlay {
            get;
            set;
        }

        public void performAction(String phase) {
            //Get a list of actions to perform durning the appropiate hase
            throw new NotImplementedException();
        }


        public void addGoldToPool() {
            //Create a popup that will parse through card that can produce gold (Check boxes)
            throw new NotImplementedException();
        }

        /* Move a Holding or Personality card from a province into play
         */
        private void bringIntoPlay(DynastyCard c) {
            throw new NotImplementedException();
        }

        // TODO: Need to think this through...
        public void recruitCardFromProvince(int provNum) {
            // Why 0? I assume that we're taking the head of the 
            Card cardToPurchase = cardsInProvince[provNum][0];

            Console.WriteLine("Card selected to purchase is:" + cardToPurchase.name);

            // TODO: Handle this differently. Can we *only* recruit Holding cards?
            if (cardToPurchase.canBeRecruitedBy(this)) {
                // i.e., we can 
            }
            /*if (cardToPurchase.IsHolding == true) {
                cardsInPlay.Add(cardToPurchase); // move card to play
                cardsInProvince[provNum][0] = cardsInDynastyDeck[0]; // 
                cardsInDynastyDeck.RemoveAt(0);
                cardsInProvince[provNum][0].turnFaceDown();

                // XXX: wtf is going on here?
                // Removed GUI logic
                /*switch (provNum + 1) {
                    case 1:
                        thePlayArea.myP1.Image = L5R.Properties.Resources.dynastyBack;
                        Console.WriteLine("New Card in province:" + (provNum + 1) + " Card name:" + cardsInProvince[provNum, 0].name);
                        break;
                    case 2:
                        thePlayArea.myP2.Image = L5R.Properties.Resources.dynastyBack;
                        Console.WriteLine("New Card in province:" + (provNum + 1) + " Card name:" + cardsInProvince[provNum, 0].name);
                        break;
                    case 3:
                        thePlayArea.myP3.Image = L5R.Properties.Resources.dynastyBack;
                        Console.WriteLine("New Card in province:" + (provNum + 1) + " Card name:" + cardsInProvince[provNum, 0].name);
                        break;
                    case 4:
                        thePlayArea.myP4.Image = L5R.Properties.Resources.dynastyBack;
                        Console.WriteLine("New Card in province:" + (provNum + 1) + " Card name:" + cardsInProvince[provNum, 0].name);
                        break;
                }

                
            }*/
        }
    }
}