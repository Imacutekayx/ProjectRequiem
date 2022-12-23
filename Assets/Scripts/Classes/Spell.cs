using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Spell {
        public string[,] arr_effects;
        public string str_targetNeeded;
        public byte byt_mpCost;
        public byte byt_castTime;

        public Spell(){}
    }
}
