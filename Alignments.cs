using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R {
    public class Alignments {
        public class Alignment {
            readonly string name;
            public Alignment(string name) {
                this.name = name;
            }
        }
        // TODO: add the rest of the possible clan alignments
        public static Alignment Mantis = new Alignment("Mantis");
        public static Alignment Unaligned = new Alignment("Unaligned");
    }
}
