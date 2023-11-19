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

using UnityEngine;
using UnityEngine.UI;

namespace DarkTreeFPS
{
    public class InventoryInteraction : MonoBehaviour
    {
        public Item item;
        public Inventory inventory;
        public Text infoText;

        private void Start()
        {
            inventory = FindObjectOfType<Inventory>();
        }

        public void RemoveItem()
        {
            inventory.RemoveItem(item, false);
            this.gameObject.SetActive(false);
        }

        public void Useitem()
        {
            if (item.type == ItemType.consumable)
            {
                inventory.UseItem(item, false);
            }
            gameObject.SetActive(false);
        }
    }
}
