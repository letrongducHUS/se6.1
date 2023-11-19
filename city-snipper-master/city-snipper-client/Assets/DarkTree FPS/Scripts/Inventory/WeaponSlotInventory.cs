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
using UnityEngine.UI;

namespace DarkTreeFPS
{
    public class WeaponSlotInventory : MonoBehaviour
    {
        public Text weaponName;
        public Text ammoCount;
        
        public int slotIndex;

        public Button dropButton;

        private Image image;

        private WeaponManager weaponManager;

        void Start()
        {
            image = GetComponent<Image>();
            weaponManager = FindObjectOfType<WeaponManager>();
        }
        
        void Update()
        {
            if(weaponManager.slots[slotIndex].storedWeapon != null)
            {
                image.sprite = weaponManager.slots[slotIndex].storedWeapon.weaponSetting.weaponIcon;
                ammoCount.text = weaponManager.slots[slotIndex].storedWeapon.currentAmmo.ToString();
                weaponName.text = weaponManager.slots[slotIndex].storedWeapon.weaponName;

                image.color = Color.white;

                dropButton.gameObject.SetActive(true);
            }
            else
            {
                image.sprite = null;
                ammoCount.text = "";
                weaponName.text = "";

                image.color = Color.clear;

                dropButton.gameObject.SetActive(false);
            }
        }
    }
}
