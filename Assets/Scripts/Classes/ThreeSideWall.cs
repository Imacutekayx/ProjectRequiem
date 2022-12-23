using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class ThreeSideWall : Wall {
        public new const byte NUMBERSIDE = 3;
        public byte[] arr_peripheralC;
        public char chr_heightSide;
        public char chr_widthSide;

        public ThreeSideWall(){}
    }
}
