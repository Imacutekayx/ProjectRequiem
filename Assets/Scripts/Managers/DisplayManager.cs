using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class DisplayManager {
        public GameObject[,] arr_grid;
        private GameObject gridObjects;
        private GameObject addsZeroObjects;
        private GameObject addsOneObjects;
        private GameObject addsTwoObjects;
        private GameObject wallsThreeObjects;
        private GameObject wallsFourObjects;
        private GameObject charactersObjects;
        private GameObject enemiesObjects;
        private GameObject npcsObjects;
        private Dictionary<byte, GameObject> arr_wallMasks;
        private byte[,] arr_oldDisplayableCases;

        public DisplayManager(){}

        public void LoadNewScene(byte byt_sceneIndex){}

        public void DisplayObject(string str_objectType, byte byt_objectIndex){}

        public void RefreshSkins(){}

        public void DisplayVisibleObjects(){}

        public void DisplayMenu(string str_menu){}

        private void DisplayWallMasks(){}

        private void ChangeObjectsVisibility(){}

        private void DisplayVisibleCases(){}
    }
}