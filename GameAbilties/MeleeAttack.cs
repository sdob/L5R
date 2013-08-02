using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R
{
    class MeleeAttack : Action
    {

        private L5R.GameState.GameState currentGameState;
        private List<L5R.Card> legalTargets;
        private List<L5R.Card> validTargets;
        private List<L5R.Card> myCardsInPlay;
        private List<L5R.Card> opCardsInPlay;
        private List<L5R.Card> myFateDiscard;
        private List<L5R.Card> myDynastyDiscard;
        private List<L5R.Card> opFateDiscard;
        private List<L5R.Card> opDynastyDiscard;
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


        public void setActiveGameState(L5R.GameState.GameState gs)
        {
            this.currentGameState = gs;
            if (gs.getPlayer1().getPlayerPerformingAction() == true)
            {
                this.opCardsInPlay = gs.getPlayer2().getCardsInPlay();
                this.opDynastyDiscard = gs.getPlayer2().getCardsInDynastyDiscard();
                this.opFateDiscard = gs.getPlayer2().getCardsInFateDiscard();
                this.playerActionPerformedOn = gs.getPlayer2();

                this.myDynastyDiscard = gs.getPlayer1().getCardsInDynastyDiscard();
                this.myFateDiscard = gs.getPlayer1().getCardsInFateDiscard();
                this.myCardsInPlay = gs.getPlayer1().getCardsInPlay();
                this.playerPerformingAction = gs.getPlayer1();
            }
            else
            {
                this.opCardsInPlay = gs.getPlayer1().getCardsInPlay();
                this.opDynastyDiscard = gs.getPlayer1().getCardsInDynastyDeck();
                this.opFateDiscard = gs.getPlayer1().getCardsInFateDiscard();
                this.playerActionPerformedOn = gs.getPlayer1();


                this.myDynastyDiscard = gs.getPlayer2().getCardsInDynastyDiscard();
                this.myFateDiscard = gs.getPlayer2().getCardsInFateDiscard();
                this.myCardsInPlay = gs.getPlayer2().getCardsInPlay();
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
            t = this.pickTarget(this.getLegalTargets());
            if (this.opCardsInPlay[t].getCardForce() <= meleeStrength)
            {   
                //Add to appropiate discard list
                //Remove from the inplay List

                if (this.opCardsInPlay[t].getIsFateCard() == true)
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



                
                
            }
        }

        public List<L5R.Card> getLegalTargets()
        {
            this.validTargets = new List<L5R.Card>();
            int j = 0;
            for (int i = 0; i < this.opCardsInPlay.Count; i++)
            {
                if (this.opCardsInPlay[i].getCanBeRanged() == true)
                {
                    validTargets[j] = this.opCardsInPlay[i];
                    j++;
                }
            }

            return validTargets;
        }

        public int pickTarget(List<L5R.Card> validTargets)
        {
            //Display list of valid targets via popup/Radio button and pick one

            return 1;

        
        }
    }
}
