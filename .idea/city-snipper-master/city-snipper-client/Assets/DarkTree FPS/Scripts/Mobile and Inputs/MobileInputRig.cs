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

namespace DarkTreeFPS
{
    public class MobileInputRig : MonoBehaviour
    {
        WeaponManager manager;
        
        public bool setFire = false;

        private void Start()
        {
            manager = FindObjectOfType<WeaponManager>();
        }

        private void Update()
        {
            if (setFire)
                Fire();
        }
        
        public void SetFire(bool state)
        {
            setFire = state;
        }

        public void Fire()
        {
            if(manager.activeSlot.storedWeapon != null && !manager.grenade.isActiveAndEnabled)
            {
                manager.activeSlot.storedWeapon.FireMobile();
            }
            else if(manager.grenade.isActiveAndEnabled)
            {
                manager.grenade.GetComponent<Weapon>().animator.SetTrigger("Throw");
                manager.grenade.GetComponent<Weapon>().isThrowingGrenade = true;
            }
        }

        public void Aim()
        {
            if (manager.activeSlot.storedWeapon != null)
            {
                manager.activeSlot.storedWeapon.AimMobile();
            }
        }

        public void Reload()
        {
            if (manager.activeSlot.storedWeapon != null)
            {
                manager.activeSlot.storedWeapon.ReloadBegin();
            }
        }
    }
}
