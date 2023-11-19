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
    public class UseObjects : MonoBehaviour
    {
        [Tooltip("The distance within which you can pick up item")]
        public float distance = 1.5f;
        
        private GameObject use;
        private GameObject useCursor;
        private Text useText;

        private InputManager input;
        private Inventory inventory;

        private Button useButton;

        private void Start()
        {
            useCursor = GameObject.Find("UseCursor");
            useText = useCursor.GetComponentInChildren<Text>();
            useCursor.SetActive(false);

            inventory = FindObjectOfType<Inventory>();
            input = FindObjectOfType<InputManager>();

            if (InputManager.useMobileInput)
            {
                useButton = GameObject.Find("UseButton").GetComponent<Button>();
                useButton.gameObject.SetActive(false);
            }
        }

        void Update()
        {
            Pickup();
        }

        public void Pickup()
        {
            RaycastHit hit;

            //Hit an object within pickup distance
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {
                if (hit.collider.tag == "Item")
                {
                    //Get an item which we want to pickup
                    use = hit.collider.gameObject;
                    useCursor.SetActive(true);

                    if (InputManager.useMobileInput)
                        useButton.gameObject.SetActive(true);

                    if (use.GetComponent<Item>())
                    {
                        useText.text = use.GetComponent<Item>().title;
                        if (!InputManager.useMobileInput)
                        {
                            if (Input.GetKeyDown(input.Use))
                            {
                                inventory.GiveItem(use.GetComponent<Item>());
                                use = null;
                            }
                        }
                        if(InputManager.useMobileInput)
                        {
                            var item = use.GetComponent<Item>();
                            useButton.onClick.RemoveAllListeners();
                            useButton.onClick.AddListener(() => { inventory.GiveItem(item); });
                            use = null;
                            return;
                        }
                            
                    }
                    //useText.text = use.weaponNameToAddAmmo + " Ammo x " + use.ammoQuantity;
                    else if (use.GetComponent<WeaponPickup>()) {

                        useText.text = use.GetComponent<WeaponPickup>().weaponNameToEquip;

                        if (InputManager.useMobileInput)
                            useButton.gameObject.SetActive(true);

                        if (!InputManager.useMobileInput)
                        {
                            if (Input.GetKeyDown(input.Use))
                            {
                                use.GetComponent<WeaponPickup>().Pickup();
                            }
                        }
                        if(InputManager.useMobileInput)
                        {
                            var item = use.GetComponent<WeaponPickup>();
                            useButton.onClick.RemoveAllListeners();
                            useButton.onClick.AddListener(() => { item.Pickup(); });
                            use = null;
                            return;
                        }
                    }
                }
                else
                {
                    //Clear use object if there is no an object with "Item" tag
                    use = null;
                    useCursor.SetActive(false);

                    if(InputManager.useMobileInput)
                        useButton.gameObject.SetActive(false);

                    useText.text = "";
                }
            }
            else
            {
                useCursor.SetActive(false);

                if (InputManager.useMobileInput)
                    useButton.gameObject.SetActive(false);

                useText.text = "";
            }
        }
    }
}
