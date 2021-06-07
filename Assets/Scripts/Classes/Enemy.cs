using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Enemy : Fighter {
        public string str_description;
        public Script[] arr_scripts;
        public byte[,] arr_visibleCases;
        public byte[] arr_visibleFighters;
        public byte byt_teamIndex;
        public bool bol_inFight;
        public byte[,] arr_patrol;
        public byte byt_patrolIndex;
        public bool bol_patrolCircle;

        public Enemy(){}
    }
}