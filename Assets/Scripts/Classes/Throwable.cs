using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Throwable : Item {
        public const string ITEMTYPE = "Throwable";

        public byte byt_scope;
        public string[,] arr_effects;

        public Throwable(){
            
        }
    }
}