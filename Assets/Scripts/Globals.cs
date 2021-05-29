using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem {
    public static class Globals {
        public static bool bol_isHost;
        public static Armor[] arr_armor;
        public static Weapon[] arr_weapon;
        public static Throwable[] arr_throwable;
        public static Modifier[] arr_modifier;
        public static Speech[] arr_speech;
        public static Quest[] arr_quest;
        public static Scene[] arr_scene;
        public static byte byt_currentSceneIndex;
        public static byte byt_playerIndex;
        public static CameraManager cameraManager;
        public static TimeManager timeManager;
        public static MovementManager movementManager;
        public static ScriptManager scriptManager;
        public static VisibilityManager visibilityManager;
        public static AIManager aiManager;
        public static HazardManager hazardManager;
        public static PlayerManager playerManager;
        public static ProjectileManager projectileManager;
        public static FightManager fightManager;
        public static DisplayManager displayManager;

        public static void ImportAdventure(){}

        public static void ImportSave(){}

        public static void ExportSave(){}
    }
}