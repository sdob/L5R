using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.GameAbilities {
    // A Condition is a wrapper object for a Boolean that
    // determines whether a given Ability can be performed
    // under a given game state.
    public interface Condition {
        Boolean isSatisfiedBy(GameState gs, Player owner);
    }
}
