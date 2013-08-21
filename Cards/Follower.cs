using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.Cards {
    public class Follower : Attachment {
        //public string name;
        public int force;
        public int chi;
        public int honorRequirement;
        public int goldCost;
        public int personalHonor;
        public int focusValue {
            get;
            set;
        }

        public Follower(String name, int force, int chi, int honorRequirement, int goldCost, int personalHonor, int focusValue) {
            this.name = name;
            this.force = force;
            this.chi = chi;
            this.honorRequirement = honorRequirement;
            this.goldCost = goldCost;
            this.personalHonor = personalHonor;
            this.focusValue = focusValue;
        }

        public override bool canBeRecruitedBy(Player p) {
            throw new NotImplementedException();
        }

        public override void getDiscardedBy(Player p) {
            throw new NotImplementedException();
        }

        /*string Card.name {
            get { return this.name; }
        }

        bool Card.IsBowed {
            get { throw new NotImplementedException(); }
        }

        void Card.straighten() {
            throw new NotImplementedException();
        }

        bool Card.IsFaceDown {
            get { throw new NotImplementedException(); }
        }

        void Card.turnFaceUp() {
            throw new NotImplementedException();
        }

        void Card.turnFaceDown() {
            throw new NotImplementedException();
        }

        string Card.GetTextBox() {
            throw new NotImplementedException();
        }*/
    }
}
