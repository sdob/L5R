using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.Cards {
    public class Stronghold : Card {

        //string name {get; set;}
        public Alignments.Alignment alignment {
            get;
            private set;
        }
        int baseStrength {get; set;}
        int goldProduction {get; set;}
        int startingFamilyHonor {get; set;}

        public Stronghold(String name, int baseStrength, int goldProduction, int startingFamilyHonor) {
            this.name = name;
            this.baseStrength = baseStrength;
            this.goldProduction = goldProduction;
            this.startingFamilyHonor = startingFamilyHonor;
        }

        public override bool canBeRecruitedBy(Player p) {
            throw new NotImplementedException();
        }

        public override void getDiscardedBy(Player p) {
            throw new NotImplementedException();
        }
    }
}
