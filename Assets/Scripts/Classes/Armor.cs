using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Armor : Item {
        public const string ITEMTYPE = "Armor";

        public string str_type;
        public byte byt_physicalArmor;
        public byte byt_magicalArmor;
        public byte byt_weight;
        public string[,] arr_effects;
        //Ask Joseph
        public string position;

        public Armor(){

        }
    }
}