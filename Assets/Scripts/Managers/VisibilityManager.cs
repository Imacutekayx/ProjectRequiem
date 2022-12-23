using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class VisibilityManager {
        public byte[,] arr_displayableCases;
        public byte[] arr_displayableWalls;
        private byte[,] arr_visibleCases;
        private bool bol_isPlayer;

        public VisibilityManager(){}

        public byte[,] Compute(bool bol_isPlayer, byte byt_sight, byte byt_originX, byte byt_originY){ return new byte[2,0]; }

        private void ComputeVisibleCases(byte byt_octant, byte byt_originX, byte byt_originY, byte byt_rangeLimit, byte byt_x, Slope slp_top, Slope slp_bottom){}

        private bool BlocksLight(byte byt_x, byte byt_y, byte byt_octant, byte byt_originX, byte byt_originY){ return true; }

        private void SetVisible(byte byt_x, byte byt_y, byte byte_octant, byte byt_originX, byte byt_originY){}

        private byte GetDistance(byte byt_x, byte byt_y){ return 0; }
    }
}