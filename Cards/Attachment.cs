using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.Cards {
    public abstract class Attachment : Card {
        int goldCost {get; set;}
        int focusValue { get; set; }
    }
}
