using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using L5R.Cards;

namespace L5R
{
    class MeleeAttack : Action
    {

        private GameState currentGameState;
        // XXX: No way do we need all of these as instance variables
        private List<Card> legalTargets;
        private List<Card> validTargets;
        private List<Card> myCardsInPlay;
        private List<Card> opCardsInPlay;
        private List<FateCard> myFateDiscard;
        private List<DynastyCard> myDynastyDiscard;
        private List<FateCard> opFateDiscard;
        private List<DynastyCard> opDynastyDiscard;
        private int meleeStrength;
        private string actionText;

        private Player playerPerformingAction;
        private Player playerActionPerformedOn;


        public MeleeAttack(int str,string actionText)
        {
            this.legalTargets = new List<Card>();
            this.validTargets = new List<Card>();
            this.meleeStrength = str;
            this.actionText = actionText;
        
        }


        public void setActiveGameState(GameState gs)
        {
            this.currentGameState = gs;
            // TODO: Man, this looks ugly...
            if (gs.getPlayer1().getPlayerPerformingAction() == true)
            {
                this.opCardsInPlay = gs.getPlayer2().cardsInPlay;
                this.opDynastyDiscard = gs.getPlayer2().cardsInDynastyDiscard;
                this.opFateDiscard = gs.getPlayer2().cardsInFateDiscard;
                this.playerActionPerformedOn = gs.getPlayer2();

                this.myDynastyDiscard = gs.getPlayer1().cardsInDynastyDiscard;
                this.myFateDiscard = gs.getPlayer1().cardsInFateDiscard;
                this.myCardsInPlay = gs.getPlayer1().cardsInPlay;
                this.playerPerformingAction = gs.getPlayer1();
            }
            else
            {
                this.opCardsInPlay = gs.getPlayer1().cardsInPlay;
                this.opDynastyDiscard = gs.getPlayer1().cardsInDynastyDeck;
                this.opFateDiscard = gs.getPlayer1().cardsInFateDiscard;
                this.playerActionPerformedOn = gs.getPlayer1();


                this.myDynastyDiscard = gs.getPlayer2().cardsInDynastyDiscard;
                this.myFateDiscard = gs.getPlayer2().cardsInFateDiscard;
                this.myCardsInPlay = gs.getPlayer2().cardsInPlay;
                this.playerPerformingAction = gs.getPlayer2();
            }
        }

        public string getActionText()
        {
            return this.actionText;
        }

        public void performAction()
        {
            int t;
            // TODO: this is broken
            //t = this.pickTarget(this.getLegalTargets());
            /*if (this.opCardsInPlay[t].Force <= meleeStrength)
            {   
                //Add to appropiate discard list
                //Remove from the inplay List

                if (this.opCardsInPlay[t].IsFateCard == true)
                {
                    this.opFateDiscard.Add(this.opCardsInPlay[t]);
                    this.opCardsInPlay.RemoveAt(t);
                    this.playerActionPerformedOn.setCardsInPlay(this.opCardsInPlay);
                    this.playerActionPerformedOn.setCardsInFateDiscard(this.opFateDiscard);
                }
                else 
                {
                    this.opDynastyDiscard.Add(this.opCardsInPlay[t]);
                    this.opCardsInPlay.RemoveAt(t);
                    this.playerActionPerformedOn.setCardsInPlay(this.opCardsInPlay);
                    this.playerActionPerformedOn.setCardsInDynastyDiscard(this.opDynastyDiscard);
                }
            }*/
        }

        public List<L5R.Card> getLegalTargets()
        {
            throw new NotImplementedException();
            /*this.validTargets = new List<L5R.Card>();
            int j = 0;
            for (int i = 0; i < this.opCardsInPlay.Count; i++)
            {
                if (this.opCardsInPlay[i].CanBeRanged == true)
                {
                    validTargets[j] = this.opCardsInPlay[i];
                    j++;
                }
            }

            return validTargets;*/
        }

        public int pickTarget(List<L5R.Card> validTargets)
        {
            //Display list of valid targets via popup/Radio button and pick one

            return 1;
        }

        public bool actionTargetsCardInUnit()
        {
            //This will always be true
            return true;
        }
    }
}
