using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Quest {
        public Objective[] arr_objectives;
        public Dictionary<Item, byte> arr_reward;

        public Quest(){}
    }
}
