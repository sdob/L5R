using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.Cards {
    public abstract class DynastyCard : Card {

        override public void getDiscardedBy(Player p) {
            p.cardsInDynastyDiscard.Add(this);
        }

        public abstract void handleEventsPhase(GameState gs);
    }
}
