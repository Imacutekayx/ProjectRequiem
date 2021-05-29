using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Weapon : Item {
        public const string ITEMTYPE = "Weapon";

        public byte byt_damageValue;
        public string str_type;
        public string[,] arr_effects;

        public Weapon(){
            
        }
    }
}