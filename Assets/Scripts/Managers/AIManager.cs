using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class AIManager {
        public AIManager(){}

        public void Execute(Action action){}

        public bool RollDice(byte byt_enemyIndex, string str_statName, byte byt_disadvantage){}

        public void CheckVisibleFighter(byte byt_fighterIndex){}

        private void ChooseAction(byte byt_enemyIndex){}
    }
}