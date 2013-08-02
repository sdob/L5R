using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R
{
    interface Card
    {

         void addAction(L5R.Action action);
         void setBaseForce(int bForce);
         void setBaseChi(int bChi);
         void setHonourRequirment(int hReq);
         void setBaseGoldCost(int bGold);
         void setBasePersonalHonour(int pHonour);
         void setForce(int f);
         void setChi(int c);
         void setCardName(string name);
         void setCardTraits(string[] traits);
         void setBowedStatus(bool bowed);
         bool getIsFateCard();
         int getCardForce();
         bool getCanBeRanged();      

    }
}
