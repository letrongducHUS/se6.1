/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

/// DarkTreeDevelopment (2019) DarkTree FPS v1.1
/// If you have any questions feel free to write me at email --- darktreedevelopment@gmail.com ---
/// Thanks for purchasing my asset!

using UnityEngine;

namespace DarkTreeFPS
   {
    public class ObjectHealth : MonoBehaviour {

        //Blank class used for interaction between player damage and reciever

        public float health = 100;
        
        public bool instantiateAfterDeath = false;

        public GameObject objToInstantiate;

        void Update()
        {
            if (health < 0)
            {
                if(instantiateAfterDeath)
                    Instantiate(objToInstantiate, transform.position, transform.rotation);

                Destroy(gameObject);
            }
        }
    }
}
