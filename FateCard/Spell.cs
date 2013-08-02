using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.FateCard
{
    class Spell : Card
    {
        private bool isFateCard;
        private bool isbowed;
        private bool isAttachment;
        private bool canBeRanged;
        private bool isPersonality;
        private bool isFollower;
        private bool isItem;
        private bool isSpell;
        private bool isHolding;
        private bool hasAttachments;
        private bool hasFollowerAttachments;
        private bool hasSpellAttachments;
        private bool hasItemAttachments;


        private int baseForce;
        private int baseChi;
        private int honourRequirment;
        private int baseGoldCost;
        private int basePersonalHonour;
        private int force;
        private int chi;
        private int personalHonour;

        private string cardName;
        private string[] traits;


        private List<L5R.Action> cardActions;
        
        public Spell()
        {
            this.isFateCard = true;
            this.isbowed = false;
            this.isPersonality = false;
            this.isFollower = false;
            this.isAttachment = true;
            this.isHolding = false;
            this.isItem = false;
            this.isSpell = true;
            this.canBeRanged = false;
            this.hasAttachments = false;
            this.hasFollowerAttachments = false;
            this.hasItemAttachments = false;
            this.hasSpellAttachments = false;
        }

        public void addAction(L5R.Action action)
        {
            this.cardActions.Add(action);
        }

        public void setBaseForce(int bForce)
        {
            this.baseForce = bForce;
        }

        public void setBaseChi(int bChi)
        {
            this.baseChi = bChi;
        }

        public void setHonourRequirment(int hReq)
        {
            this.honourRequirment = hReq;
        }

        public void setBaseGoldCost(int bGold)
        {
            this.baseGoldCost = bGold;
        }

        public void setBasePersonalHonour(int pHonour)
        {
            this.basePersonalHonour = pHonour;
        }

        public void setForce(int f)
        {
            this.force = f;
        }

        public void setChi(int c)
        {
            this.chi = c;
        }

        public void setCardName(string name)
        {
            this.cardName = name;
        }

        public void setCardTraits(string[] traits)
        {
            this.traits = traits;
        }

        public void setBowedStatus(bool bowed)
        {
            this.isbowed = bowed;
        }

        public bool getIsFateCard()
        {
            return isFateCard;
        }

        public int getCardForce()
        {
            return this.force;
        }

        public bool getCanBeRanged()
        {
            return this.canBeRanged;
        }

        
    }
}
