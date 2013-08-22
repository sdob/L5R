using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.GameAbilities {
    public interface Result {
        void performAction(GameState gs);
    }
}
