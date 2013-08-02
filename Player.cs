﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R
{
    class Player
    {
        private bool isActivePlayer;
        private bool playerPerformingAction;


        private List<L5R.Card> cardsInPlay;
        private List<L5R.Card> cardsInFateDeck;
        private List<L5R.Card> cardsInDynastyDeck;
        private List<L5R.Card> cardsInFateDiscard;
        private List<L5R.Card> cardsInDynastyDiscard;
        private List<L5R.Card> cardsInHand;
        private List<List<L5R.Card>> cardsInProvence;
        private List<L5R.Unit.Unit> unitsInPlay;
        
        
     

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
            this.cardsInProvence=new List<List<Card>>(4);



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


    }
}
