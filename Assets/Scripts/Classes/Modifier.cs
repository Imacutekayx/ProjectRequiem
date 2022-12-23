using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Modifier : Item {
        public new const string ITEMTYPE = "Modifier";

        public string[,] arr_effects;

        public Modifier(){
            
        } 
    }
}