using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Requiem;
using Requiem.Managers;
using Requiem.Classes;

namespace Requiem.Managers {
    public class FightManager {
        private string[,] arr_effectsSource;

        public FightManager(){}

        public void AttackWeapon(byte byt_fighterIndex, byte byt_weaponIndex, byte byt_targetX, byte byt_targetY){}

        public bool AttemptDodgeProjectile(byte byt_fighterReflex, byte byt_actionConcentration){}

        public void CastSpell(byte byt_fighterIndex, byte byt_spellIndex, byte byt_targetX, byte byt_targetY){}

        public void Execute(Action action){}

        public bool AttemptRoll(byte byt_fighterStat, byte byt_disadvantage){}

        public void DealAreaDamage(byte byt_originX, byte byt_originY, byte byt_zoneSize, string[,] arr_areaEffects){}

        public void UseItem(string str_type, byte byt_targetX, byte byt_targetY, string[,] arr_effects){}

        private byte CalculateDamageDealt(byte byt_fighterDamage, byte byt_attackDamage){}

        private bool AttemptAttack(byte byt_fighterPrecision, byte byt_attackPrecision){}

        private byte CalculateCastTime(byte byt_fighterCast, byte byt_spellCast){}

        private void CreateProjectile(byte byt_targetX, byte byt_targetY, string str_type, string str_form, byte byt_length, byte byt_width, byte byt_speed, byte byt_sceneIndex, byte byt_sceneObjectIndex, string[,] arr_effects, byte[,] arr_path){}

        private void ExecuteInstant(byte byt_fighterIndex, string[,] arr_effects){}

        private void ReceiveEffects(byte byt_fighterIndex, string[,] arr_effects){}

        private void ReceiveAttack(byte byt_fighterIndex, Dictionary<string, byte> arr_attacks){}

        private bool AttemptParry(byte byt_fighterParry, string str_weaponType){}

        private bool AttemptDodge(byte byt_fighterDodge, byte byt_armorWeight, string str_weaponType){}

        private byte CalculateDamageReceived(byte byt_fighterDefense, byte byt_armorDefense){}

        private bool AttemptStatusRemoval(byte byt_fighterDefense, byte byt_statusDefense, byte byt_duration){}
    }
}