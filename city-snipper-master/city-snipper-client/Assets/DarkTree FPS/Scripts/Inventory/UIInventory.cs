/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

/// DarkTreeDevelopment (2019) DarkTree FPS v1.2
/// If you have any questions feel free to write me at email --- darktreedevelopment@gmail.com ---
/// Thanks for purchasing my asset!

using System.Collections.Generic;
using UnityEngine;

namespace DarkTreeFPS
{
    public class UIInventory : MonoBehaviour
    {
        public List<UIItem> UIItems = new List<UIItem>();
        public GameObject slotPrefab;
        public Transform slotPanel;


        public int numberOfSlots = 16;

        private void Awake()
        {
            for (int i = 0; i < numberOfSlots; i++)
            {
                GameObject instance = Instantiate(slotPrefab);
                instance.transform.SetParent(slotPanel);
                UIItems.Add(instance.GetComponentInChildren<UIItem>());
            }
        }

        public void UpdateSlot(int slot, Item item)
        {
            UIItems[slot].UpdateItem(item);
        }

        public void AddNewItem(Item item)
        {
            UpdateSlot(UIItems.FindIndex(i => i.item == null), item);
        }

        public void RemoveItem(Item item)
        {
            UpdateSlot(UIItems.FindIndex(i => i.item == item), null);
        }
    }
}
