/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace DarkTreeFPS {

    [CustomEditor(typeof(Weapon))]
    public class WeaponCustomInspector : Editor
    {
        Weapon weapon;

        public override void OnInspectorGUI()
        {
            weapon = target as Weapon;
            
            DrawGeneral();
            
            if(weapon.weaponSetting.weaponType == WeaponType.Melee)
            {
                DrawMelee();
            }
            else if(weapon.weaponSetting.weaponType == WeaponType.Grenade)
            {
                DrawGrenade();
            }
            else
            {
                DrawFirearms();
            }

            EditorUtility.SetDirty(weapon);
        }

        public void DrawGeneral()
        {
            GUILayout.Label("General settings", EditorStyles.boldLabel);
            GUILayout.BeginVertical("HelpBox");
            weapon.weaponSetting = (WeaponSettingSO)EditorGUILayout.ObjectField(weapon.weaponSetting, typeof(WeaponSettingSO), false);
            GUILayout.Label("Weapon name");
            weapon.weaponName = GUILayout.TextField(weapon.weaponName);
            weapon.useAnimator = GUILayout.Toggle(weapon.useAnimator, "Use animator");
            GUILayout.EndVertical();
        }
        public void DrawMelee()
        {
            EditorGUILayout.HelpBox("There is no settings for melee weapon type. See weapon settings", MessageType.Info);
        }
        public void DrawFirearms()
        {
            GUILayout.Label("Firearms settings", EditorStyles.boldLabel);
            GUILayout.BeginVertical("HelpBox");
            GUILayout.Label("Ammo Item ID");
            weapon.ammoItemID = EditorGUILayout.IntField(weapon.ammoItemID);
            GUILayout.Label("Reload animation duration");
            weapon.reloadAnimationDuration = EditorGUILayout.FloatField(weapon.reloadAnimationDuration);
            GUILayout.Label("Auto reloading");
            weapon.autoReload = EditorGUILayout.Toggle(weapon.autoReload);
            GUILayout.Label("Current ammo value");
            weapon.currentAmmo = EditorGUILayout.IntField(weapon.currentAmmo);
            GUILayout.Label("Max ammo value");
            weapon.maxAmmo = EditorGUILayout.IntField(weapon.maxAmmo);
            weapon.fireMode = (Weapon.FireMode)EditorGUILayout.EnumPopup("FireMode", weapon.fireMode);
            GUILayout.BeginVertical("GroupBox");
            GUILayout.Label("Helpers", EditorStyles.centeredGreyMiniLabel);
            GUILayout.Label("Muzzle flash transform");
            weapon.muzzleFlashTransform = (Transform)EditorGUILayout.ObjectField(weapon.muzzleFlashTransform, typeof(Transform), true);
            GUILayout.Label("Shell eject transform");
            weapon.shellTransform = (Transform)EditorGUILayout.ObjectField(weapon.shellTransform, typeof(Transform), true);
            GUILayout.Label("Bullet spawn transform");
            weapon.bulletTransform = (Transform)EditorGUILayout.ObjectField(weapon.bulletTransform, typeof(Transform), true);
            EditorGUILayout.HelpBox("Z axis is forward axis of each transform. Check forward for each helper to set right direction!", MessageType.Warning);
            GUILayout.EndVertical();

            GUILayout.EndVertical();
        }
        public void DrawGrenade()
        {
            GUILayout.Label("Ammo Item ID");
            weapon.ammoItemID = EditorGUILayout.IntField(weapon.ammoItemID);
        }
    }
}
