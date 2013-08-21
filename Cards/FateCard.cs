using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.Cards {
    public abstract class FateCard : Card {
        override public void getDiscardedBy(Player p) {
            p.cardsInFateDiscard.Add(this);
        }
    }
}
