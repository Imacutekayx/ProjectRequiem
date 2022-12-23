using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Wall {
        public const byte NUMBERSIDE = 4;
        public byte byt_coordinateX;
        public byte byt_coordinateY;
        public byte[,] arr_peripheralN;
        public byte[,] arr_peripheralS;
        public byte[,] arr_peripheralE;
        public byte[,] arr_peripheralW;

        public Wall(){}
    }
}
