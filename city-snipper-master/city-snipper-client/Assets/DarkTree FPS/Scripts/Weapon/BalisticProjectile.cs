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
/// Thanks for purchasing my asset!!

using UnityEngine;

namespace DarkTreeFPS
{
    public class BalisticProjectile : MonoBehaviour
    {
        [HideInInspector]
        public float initialVelocity = 360;
        [HideInInspector]
        public float airResistance = 0.1f;

        private float time;

        private float livingTime = 1f;

        Vector3 lastPosition;

        public Weapon weapon;

        private void OnEnable()
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * initialVelocity);

            lastPosition = transform.position;
        }

        private void Update()
        {
            time += Time.deltaTime;

            RaycastHit hit;
            if (Physics.Linecast(lastPosition, transform.position, out hit))
            {
                weapon.ApplyHit(hit);

                gameObject.SetActive(false);
            }

            lastPosition = transform.position;

            if (time > livingTime)
            {
                gameObject.SetActive(false);
            }
        }


        private void OnDisable()
        {
            time = 0;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = Vector3.zero;
        }
    }
}
