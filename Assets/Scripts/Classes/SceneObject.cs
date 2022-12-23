using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class SceneObject {
        public string str_name;
        public byte byt_sizeX;
        public byte byt_sizeY;
        public byte byt_sizeZ;
        public byte byt_coordinateX;
        public byte byt_coordinateY;
        public byte byt_orientation;
        public Entity entity;
        public Projectile projectile;
        public bool bol_visible;
        public byte byt_sceneIndex;
        public byte byt_index;

        public SceneObject(){}
    }
}
