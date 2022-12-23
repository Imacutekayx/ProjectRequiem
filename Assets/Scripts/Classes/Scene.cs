using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Scene {
        public string str_name;
        public byte byt_sizeX;
        public byte byt_sizeY;
        public SceneObject[] arr_addsZero;
        public SceneObject[] arr_addsOne;
        public SceneObject[] arr_addsTwo;
        public SceneObject[] arr_entities;
        public Fighter[][] arr_teams;
        public Case[,] arr_cases;
        public Script[] arr_scripts;
        public Wall[] arr_walls;
        public byte byt_brightness;
        public SceneObject[,] arr_lightSources;
        public Projectile[] arr_projectiles;

        public Scene(){}
    }
}
