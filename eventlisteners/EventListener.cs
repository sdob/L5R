using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.eventlisteners {
    /* EventListeners add themselves to GameState objects and get
     * notified when things happen. This allows Card objects
     * to switch effects on/off based on what's going on during
     * the game.
     */
    public interface EventListener {
        public void eventOccurred(Event e);
    }
}
