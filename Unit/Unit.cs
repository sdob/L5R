using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.Unit
{
    class Unit
    {
        private List<L5R.Card> cardsInUnit;
        private string locationOfUnit;
        private L5R.Player owner;


        private const string locHome = "home";
        private const string oppProvence1="opP1";
        private const string oppProvence2="opP2";
        private const string oppProvence3="opP3";
        private const string oppProvence4="opP4";
        private const string myProvence1="myP1";
        private const string myProvence2="myP2";
        private const string myProvence3="myP3";
        private const string myProvence4="myP4";



        private Unit(L5R.Card personality,L5R.Player unitOwner)
        {
            cardsInUnit = new List<L5R.Card>();
            cardsInUnit.Add(personality);
            this.owner = unitOwner;

            this.locationOfUnit = locHome;

        }

        private List<L5R.Card> getCardsInUnit()
        {
            return this.cardsInUnit;
        }

        private void destroyCardInUnit(int position)
        {   //To do
            //Check if personality is destroyed. If so destroy all cards in the unit

            //Check if card is a fate or dynasty card. And add to appropiate discard pile
            if (this.cardsInUnit[position].getIsFateCard() == true)
            {
                owner.getCardsInFateDiscard().Add(this.cardsInUnit[position]);
                this.cardsInUnit.RemoveAt(position);
            }
            else 
            {
                owner.getCardsInDynastyDiscard().Add(this.cardsInUnit[position]);
                this.cardsInUnit.RemoveAt(position);
            }
        }

    }
}
