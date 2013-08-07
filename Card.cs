using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R
{
    class Card
    {

        private bool isEvent;
        private bool isHolding;
        private bool isPersonality;
        private bool isRegion;

        private bool isFollower;
        private bool isItem;
        private bool isRing;
        private bool isSpell;
        private bool isStrategy;

        private bool isFateCard;
        private bool isAttachment;
        private bool hasAttachments;
        private bool hasFollowerAttachments;
        private bool hasSpellAttachments;
        private bool hasItemAttachments;
        private bool isFaceDown;

        private bool isbowed;
        private bool canBeRanged;

        private int baseForce;
        private int baseChi;
        private int honourRequirment;
        private int baseGoldCost;
        private int basePersonalHonour;
        private int force;
        private int chi;
        private int personalHonour;
        private int goldCost;

        public int unitID;

        private string cardName;
        private string[] traits;

        private List<L5R.Action> cardActions;


        
        public bool IsEvent
        {
            get
            {
                return isEvent;
            }
            set
            {
                isEvent = value;
            }
        }
        public bool IsHolding
        {
            get
            {
                return isHolding;
            }
            set
            {
                isHolding = value;
            }
        }
        public bool IsPersonality
        {
            get
            {
                return isPersonality;
            }
            set
            {
                isPersonality = value;
            }
        }
        public bool IsRegion
        {
            get
            {
                return isRegion;
            }
            set
            {
                isRegion = value;
            }
        }

        public bool IsFollower
        {
            get
            {
                return isFollower;
            }
            set
            {
                isFollower = value;
            }
        }
        public bool IsItem
        {
            get
            {
                return isItem;
            }
            set
            {
                isItem = value;
            }
        }
        public bool IsRing
        {
            get
            {
                return isRing;
            }
            set
            {
                isRing = value;
            }
        }
        public bool IsSpell
        {
            get
            {
                return isSpell;
            }
            set
            {
                isSpell = value;
            }
        }
        public bool IsStrategy
        {
            get
            {
                return isStrategy;
            }
            set
            {
                isStrategy = value;
            }
        }

        public bool IsFateCard
        {
            get
            {
                return isFateCard;
            }
            set
            {
                isFateCard = value;
            }
        }
        public bool IsAttachment
        {
            get
            {
                return isAttachment;
            }
            set
            {
                isAttachment = value;
            }
        }
        public bool HasAttachments
        {
            get
            {
                return hasAttachments;
            }
            set
            {
                hasAttachments = value;
            }
        }
        public bool HasFollowerAttachments
        {
            get
            {
                return hasFollowerAttachments;
            }
            set
            {
                hasFollowerAttachments = value;
            }
        }
        public bool HasSpellAttachments
        {
            get
            {
                return hasSpellAttachments;
            }
            set
            {
                hasSpellAttachments = value;
            }
        }
        public bool HasItemAttachments
        {
            get
            {
                return hasItemAttachments;
            }
            set
            {
                hasItemAttachments = value;
            }
        }
        public bool IsFaceDown
        {
            get
            {
                return isFaceDown;
            }
            set
            {
                isFaceDown = value;
            }
        }

        public bool IsBowed
        {
            get
            {
                return isbowed;
            }
            set
            {
                isbowed = value;
            }
        }
        public bool CanBeRanged
        {
            get
            {
                return canBeRanged;
            }
            set
            {
                canBeRanged = value;
            }
        }

        public int BaseForce
        {
            get
            {
                return baseForce;
            }
            set
            {
                baseForce = value;
            }
        }
        public int BaseChi
        {
            get
            {
                return baseChi;
            }
            set
            {
                baseChi = value;
            }
        }
        public int HonourRequirment
        {
            get
            {
                return honourRequirment;
            }
            set
            {
                honourRequirment = value;
            }
        }
        public int BaseGoldCost
        {
            get
            {
                return baseGoldCost;
            }
            set
            {
                baseGoldCost = value;
            }
        }
        public int BasePersonalHonour
        {
            get
            {
                return basePersonalHonour;
            }
            set
            {
                basePersonalHonour = value;
            }
        }
        public int Force
        {
            get
            {
                return force;
            }
            set
            {
                force = value;
            }
        }
        public int Chi
        {
            get
            {
                return chi;
            }
            set
            {
                chi = value;
            }
        }
        public int PersonalHonour
        {
            get
            {
                return personalHonour;
            }
            set
            {
                personalHonour = value;
            }
        }

        public int GoldCost
        {
            get
            {
                return goldCost;
            }
            set
            {
                goldCost = value; 
            }
        }

        public int UnitID
        {
            get
            {
                return unitID;
            }
            set
            {
                unitID = value;
            }
        }

        public string CardName
        {
            get
            {
                return cardName;
            }
            set
            {
                cardName = value;
            }
        }


        public string[] Traits
        {
            get
            {
                return traits;
            }
            set
            {
                traits = value;
            }
        }

        public Card()
        {
            this.isFateCard = true;
            this.isbowed = false;
            this.isPersonality = false;
            this.isFollower = false;
            this.isAttachment = true;
            this.isHolding = false;
            this.isItem = true;
            this.isSpell = false;
            this.canBeRanged = false;
            this.hasAttachments = false;
            this.hasFollowerAttachments = false;
            this.hasItemAttachments = false;
            this.hasSpellAttachments = false;
            this.cardActions = new List<Action>();
           
        }

        public void addAction(L5R.Action action)
        {
            this.cardActions.Add(action);
        }

       

    }
}
