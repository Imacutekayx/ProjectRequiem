using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class CameraManager {
        public byte byt_orientation;
        public bool bol_top;
        public byte[,] arr_cameraPosition;
        public Camera camera;

        public CameraManager(){}

        public void ChangeOrientation(bool bol_isRight){}

        public void ChangeTop(){}
    }
}