using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.Cards {
    public abstract class Personality : DynastyCard {
        int honorRequirement { get; set; }
        int goldCost {get; set;}
        int personalHonor {get;set; }

        override public void getDiscardedBy(Player p) {
            // Special behaviour for discarding personalities --- they don't live in the discard pile
        }
    }
}
