using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Projectile {
        public byte byt_targetX;
        public byte byt_targetY;
        public string str_type;
        public string str_form;
        public byte byt_length;
        public byte byt_width;
        public byte byt_speed;
        public string[,] arr_effects;
        public byte byt_sceneIndex;
        public byte[,] arr_path;
        public byte byt_sceneObjectIndex;

        public Projectile(){}
    }
}
