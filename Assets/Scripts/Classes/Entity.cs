using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Entity {
        public string str_name;
        public Dictionary<Item, byte> arr_inventory;
        public byte byt_hp;
        public byte byt_sight;
        public string str_genre;
        public int int_age;
        public string str_personnality;
        public byte byt_height;
        public byte byt_length;
        public byte byt_width;
        public byte byt_index;
        public byte byt_sceneObjectIndex;
        public byte byt_sceneIndex;
        public byte[,] arr_path;

        public Entity(){}
    }
}