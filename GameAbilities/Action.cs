using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R
{
     interface Action
    {
         

         // Get the Text of the action
         string getActionText();

         //Get a list of legal targets for the action
         List<L5R.Card> getLegalTargets();

         //Pick the game state card object you want to target. Returns the position in the gamestate array
         int pickTarget(List<L5R.Card> validTargets);

         //Perform the action
         void performAction();

         void setActiveGameState(L5R.GameState.GameState gs);

         bool actionTargetsCardInUnit();

    }
}
