/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace DarkTreeFPS
{
    [CustomEditor(typeof(WeaponManager))]
    public class UpdateManagerList : Editor
    {
        WeaponManager manager;
        Sway swayTransform;

        private void OnEnable()
        {
            manager = FindObjectOfType<WeaponManager>();
            swayTransform = FindObjectOfType<Sway>();
        }

        public override void OnInspectorGUI()
        {
            Editor editor = Editor.CreateEditor(manager);
            editor.DrawDefaultInspector();

            if (GUILayout.Button("Update weapons"))
            {
                manager.weapons.Clear();
                manager.weapons = GetAllWeapons();
            }
        }

        List<Weapon> GetAllWeapons()
        {
            List<Weapon> weaponsInScene = new List<Weapon>();

            foreach (Weapon weapon in swayTransform.GetComponentsInChildren<Weapon>(true))
            {
                    weaponsInScene.Add(weapon);
            }
            return weaponsInScene;
        }
    }
}
