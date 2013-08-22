using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L5R.GameAbilities {

    public class Ability {
        public String name;
        public readonly List<String> designators;
        public Condition condition;
        public Result result;

        public Ability(string name, List<string> designators, Condition condition, Result result) {
            this.name = name;
            this.designators = designators;
            this.condition = condition;
            this.result = result;
        }

        public void use(GameState gs, Player owner) {
            if (condition.isSatisfiedBy(gs, owner)) {
                result.performAction(gs);
            }
        }
    }
}
