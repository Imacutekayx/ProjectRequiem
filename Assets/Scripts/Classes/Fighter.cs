using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Classes {
    public class Fighter : Entity {
        public byte byt_mp;
        public byte byt_precision;
        public byte byt_cast;
        public byte byt_speed;
        public byte byt_stealth;
        public byte byt_physicalDefense;
        public byte byt_magicalDefense;
        public byte byt_physicalDamage;
        public byte byt_magicalDamage;
        public byte byt_parry;
        public byte byt_dodge;
        public byte byt_reflex;
        public Dictionary<string, byte> arr_resistances;
        public byte byt_charisma;
        public byte byt_strength;
        public byte byt_dexterity;
        public byte byt_observation;
        public byte byt_arcane;
        public byte byt_intelligence;
        public byte byt_armorWeight;
        public Weapon leftWeapon;
        public Weapon rightWeapon;
        public string[] arr_weaponTypes;
        public string[] arr_armorTypes;
        
        //ARMOR Ask Joseph
        public Armor head;
        public Armor neck;
        public Armor torso;
        public Armor hands;
        public Armor leftRing;
        public Armor rightRing;
        public Armor legs;
        public Armor feet;
        //OR
        public Armor[] arr_armors;
        //OR
        public Dictionary<string, Armor> dict_arr_armors;
        //To MODIFY as well
        public bool[] arr_modifyArmor;
        //

        public Spell[] arr_spells;
        public string[,] arr_effects;
        public Dictionary<string, byte[]> arr_status;
        public Action action;

        public Fighter(){}
    }
}