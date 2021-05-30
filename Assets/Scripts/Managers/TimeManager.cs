using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class TimeManager : MonoBehaviour {
        //CURRENTLY USE A FOR TO GET THE INDEX OF BOTH ARRAYS
        //POSSIBILITY TO PUT EVERYTHING IN AN OBJECT[,]
        public byte[] arr_times;
        public Action[] arr_actions;

        public TimeManager(){}

        public void Update(){}

        public void AddAction(int int_time, Action action){}
    }
}