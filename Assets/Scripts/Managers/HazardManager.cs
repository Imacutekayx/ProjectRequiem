using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class HazardManager {
        public HazardManager(){}

        public void Execute(Action action){}

        public void ChangeCaseStatus(byte byt_coordinateX, byte byt_coordinateY, string str_status){}

        public void TriggerHazard(byte byt_entityIndex, byte byt_coordinateX, byte byt_coordinateY){}

        private void SpreadStatus(byte byt_coordinateX, byte byt_coordinateY){}
    }
}