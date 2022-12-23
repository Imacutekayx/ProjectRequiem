using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Action {
        public byte byt_sceneIndex;
        public string str_managerName;
        public string str_eventName;
        public string[] arr_eventParameters;
        public byte byt_concentrationNeeded;

        public Action(){}
    }
}
