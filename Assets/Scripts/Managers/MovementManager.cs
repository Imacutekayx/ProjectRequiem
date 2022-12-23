using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class MovementManager {
        public byte byt_nextCase;
        public byte[,] arr_path;

        public MovementManager(){}

        public void Execute(Action action){}

        public byte[,] CalculatePath(byte byt_originX, byte byt_originY, byte byt_targetX, byte byt_targetY){ return null; }

        private void StartMove(){}
    }
}