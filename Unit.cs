using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R
{
    public class Unit
    {
        private List<L5R.Card> cardsInUnit;
        private string locationOfUnit;
        private L5R.Player owner;
        private int unitNumber;


        private const string locHome = "home";
        private const string oppProvence1 = "opP1";
        private const string oppProvence2 = "opP2";
        private const string oppProvence3 = "opP3";
        private const string oppProvence4 = "opP4";
        private const string myProvence1 = "myP1";
        private const string myProvence2 = "myP2";
        private const string myProvence3 = "myP3";
        private const string myProvence4 = "myP4";



        private Unit(L5R.Card personality, L5R.Player unitOwner,int unitNum)
        {
            cardsInUnit = new List<L5R.Card>();
            cardsInUnit.Add(personality);
            this.owner = unitOwner;
            this.unitNumber = unitNum;
            this.locationOfUnit = locHome;

        }

        public List<L5R.Card> getCardsInUnit()
        {
            return this.cardsInUnit;
        }

        private void destroyCardInUnit(int position)
        {   //To do
            //Check if personality is destroyed. If so destroy all cards in the unit

            //Check if card is a fate or dynasty card. And add to appropiate discard pile
            // XXX: The *appropriate* way do to this is to implement a getDiscarded method
            // on Fate and dynasty cards
            this.cardsInUnit[position].getDiscardedBy(owner);
            this.cardsInUnit.RemoveAt(position);
            //if (this.cardsInUnit[position].IsFateCard == true)
            //{
                //owner.getCardsInFateDiscard().Add(this.cardsInUnit[position]);
                //this.cardsInUnit.RemoveAt(position);
            //}
            //else
            //{
                //owner.getCardsInDynastyDiscard().Add(this.cardsInUnit[position]);
                //this.cardsInUnit.RemoveAt(position);
            //}
        }
    }
}
