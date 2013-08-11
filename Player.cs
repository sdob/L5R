using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R
{
    class Player
    {
        private bool isActivePlayer;
        private bool playerPerformingAction;
        private bool hasPassed;


        private List<L5R.Card> cardsInPlay;
        private List<L5R.Card> cardsInFateDeck;
        private List<L5R.Card> cardsInDynastyDeck;
        private List<L5R.Card> cardsInFateDiscard;
        private List<L5R.Card> cardsInDynastyDiscard;
        private List<L5R.Card> cardsInHand;
        private List<List<L5R.Card>> cardsInProvence;

        private List<L5R.Unit> unitsInPlay;

        private int maxHandSize;
        private int goldPool;
        

        

        public Player(List<L5R.Card> dd ,List<L5R.Card> fd)
        {
            this.isActivePlayer = false;
            this.playerPerformingAction = false;
            this.cardsInPlay=new List<Card>();
            this.cardsInHand = new List<Card>();
            this.cardsInDynastyDiscard = new List<Card>();
            this.cardsInFateDiscard = new List<Card>();
            this.cardsInDynastyDeck = dd;
            this.cardsInFateDeck = fd;
            this.cardsInProvence=new List<List<Card>>();
            this.unitsInPlay = new List<Unit>();
            this.maxHandSize=8;

            Console.WriteLine("In Player Class Constructor. Num of Provences is:" + this.cardsInProvence.Count.ToString());
            

        }



        public int GoldPool
        {
            get
            {
                return goldPool;
            }
            set
            {
                goldPool = value;
            }
        }
        
        
        
        public int MaxHandSize
        {
            get
            {
                return maxHandSize;
            }
            set
            {
                maxHandSize = value;
            }
        }
        
        
        public bool HasPassed
        {
            get
            {   return this.hasPassed;
            }
            set
            {   this.hasPassed=value;
            }
        }
        
        public bool getPlayerPerformingAction()
        {
            return this.playerPerformingAction;
        }

        public void setPlayerPerformingAction(bool isPerforming)
        {
            this.playerPerformingAction = isPerforming;
        }
        
        public void setAsActivePlayer()
        {
            this.isActivePlayer = true; 
        }

        public void setAsInactivePlayer()
        {
            this.isActivePlayer = false;
        }

        public bool getIsActivePlayer()
        {
            return this.isActivePlayer;
        }

        public List<L5R.Card> getCardsInPlay()
        {
            return this.cardsInPlay;
        }

        public List<L5R.Card> getCardsInHand()
        {
            return this.cardsInHand;
        }

        public List<L5R.Card> getCardsInDynastyDiscard()
        {
            return this.cardsInDynastyDiscard;
        }

        public List<L5R.Card> getCardsInFateDiscard()
        {
            return this.cardsInFateDiscard;
        }

        public List<L5R.Card> getCardsInDynastyDeck()
        {
            return this.cardsInDynastyDeck;
        }

        public List<L5R.Card> getCardsInFateDeck()
        {
            return this.cardsInFateDeck;
        }

        public void setCardsInPlay(List<L5R.Card> inplay)
        {
            this.cardsInPlay = inplay;
        }

        public void setCardsInHand(List<L5R.Card> inHand)
        {
            this.cardsInHand = inHand;
        }
        
        public void setCardsInDynastyDiscard(List<L5R.Card> dDiscard)
        {
            this.cardsInDynastyDiscard = dDiscard;
        }
        
        public void setCardsInFateDiscard(List<L5R.Card> fDiscard)
        {
            this.cardsInFateDiscard = fDiscard;
        }
        
        public void setCardsInDynastyDeck(List<L5R.Card> dynasty)
        {
            this.cardsInDynastyDeck = dynasty;
        }
        
        public void setCardsInFateDeck(List<L5R.Card> fate)
        {
            this.cardsInFateDeck = fate;
        }


        public List<List<L5R.Card>> getCardsInProvence()
        {
            return this.cardsInProvence;
        }

        public List<L5R.Unit> getUnitsInPlay()
        {
            return this.unitsInPlay;
        }


        public void performAction(String phase)
        { 
            //Get a list of actions to perform durning the appropiate hase
        }


        public void addGoldToPool()
        {
            //Create a popup that will parse through card that can produce gold (Check boxes)
        }

        public void recruitCardFromProvence(int provNum)
        {
            List<L5R.Card> cardToPurchase = cardsInProvence[provNum];

            Console.WriteLine("Card selected to purchase is:" + cardToPurchase[0].CardName);

            if (cardToPurchase[0].IsHolding == true)
            {
                this.cardsInPlay.Add(cardToPurchase[0]);
                cardsInProvence[provNum].RemoveAt(0);
                cardsInProvence[provNum].Add(cardsInDynastyDeck[0]);
                cardsInDynastyDeck.RemoveAt(0);
            }
        }
    }
}
