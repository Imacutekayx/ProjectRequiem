using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Case {
        public byte byt_coordinateX;
        public byte byt_coordinateY;
        public byte byt_sceneObjectIndex;
        public string str_state;
        public byte byt_scriptIndex;
        public byte byt_wallIndex;
        public byte byt_clearance;
        public string str_oldState;
        public byte byt_sceneIndex;
        public string str_sceneObjectType;

        public Case(){}
    }
}
