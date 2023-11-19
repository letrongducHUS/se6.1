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
using UnityEngine.Events;

public enum ItemType {none, weapon, ammo, consumable }

public class Item : MonoBehaviour
{
    [System.Serializable]
    public class OnUseEvent : UnityEvent { }
    [System.Serializable]
    public class OnPickupEvent : UnityEvent { }

    public int id;
    public string title;
    public string description;
    public ItemType type;
    public Sprite icon;

    public int ammo;
    
    [SerializeField]
    public OnUseEvent onUseEvent;
    [SerializeField]
    public OnPickupEvent onPickupEvent;

    public Item(int id, string title, string description, ItemType itemType)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = icon;
        this.type = itemType;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = item.icon;
        this.type = item.type;
    }
}
