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
using UnityEngine.Events;
using DarkTreeFPS;
using UnityStandardAssets.ImageEffects;

namespace DarkTreeFPS
{
    public class InventoryManager : MonoBehaviour
    {
        [System.Serializable]
        public class OnInventoryOpen : UnityEvent { }
        [System.Serializable]
        public class OnInventoryClose : UnityEvent { }

        Canvas canvas;
        FPSController controller;
        Blur blurEffect;
        InputManager input;

        public static bool showInventory = false;
        public bool isOpen = true;

        public OnInventoryOpen OnOpen;
        public OnInventoryClose OnClose;

        private void Start()
        {
            canvas = GetComponent<Canvas>();
            controller = FindObjectOfType<FPSController>();
            blurEffect = Camera.main.GetComponent<Blur>();
            input = FindObjectOfType<InputManager>();

            InventoryClose();
        }

        private void Update()
        {
            if (Input.GetKeyDown(input.Inventory) && !PlayerStats.isPlayerDead && !InputManager.useMobileInput)
            {
                showInventory = !showInventory;
            }

            if (showInventory)
            {
                InventoryOpen();
            }
            else
            {
                InventoryClose();
            }
        }

        private void InventoryOpen()
        {
            if (isOpen)
                return;
            else
            {
                canvas.enabled = true;
                controller.lockCursor = false;
                blurEffect.enabled = true;
                OnOpen.Invoke();
                Time.timeScale = 0;
                isOpen = true;

            }
        }
        private void InventoryClose()
        {
            if (!isOpen)
                return;
            else
            {
                canvas.enabled = false;
                controller.lockCursor = true;
                blurEffect.enabled = false;
                OnClose.Invoke();
                Time.timeScale = 1;
                isOpen = false;
            }
        }

        public void MobileToggle()
        {
            showInventory = !showInventory;
        }
    }
}
