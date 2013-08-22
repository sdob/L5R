using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.EventListeners {
    /* An Event is just a thing that happens during the game.
     * It's better to use concrete objects than strings,
     * since it prevents fat-fingering the strings.
     */
    public class Event {

    }
    public class Events {
        public static Event END_OF_STRAIGHTEN_PHASE = new Event();
        public static Event END_OF_EVENTS_PHASE = new Event();
    }
}
