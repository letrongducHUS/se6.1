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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace DarkTreeFPS
{
    public class NPCVision : MonoBehaviour
    {
        [Tooltip("How often vision will check if player is in sight")]
        public float visibilityCheckInterval = 0.1f;
        [Tooltip("NPC field of fiev range")]
        public float FOV = 100;
        [Tooltip("How far NPC can look")]
        public float detectionRange = 30;

        private Transform player;

        [HideInInspector]
        public bool isPlayerVisible;
        [HideInInspector]
        public Vector3 lastPlayerPosition;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            StartCoroutine(VisibilityCheck(visibilityCheckInterval));
        }

        //Simple coroutine that calling with interval step
        IEnumerator VisibilityCheck(float visibilityCheckInterval)
        {
            for (; ; )
            {
                Vector3 direction = player.transform.position - transform.position;
                float angle = Vector3.Angle(direction, transform.forward);

                RaycastHit hit;

                if (angle < FOV * 0.5f)
                {
                    if (Physics.Raycast(transform.position, direction, out hit, detectionRange))
                    {
                        if (hit.transform.tag == "Player")
                        {
                            Debug.DrawLine(transform.position, player.transform.position, Color.green);
                            isPlayerVisible = true;
                            lastPlayerPosition = player.transform.position;
                        }
                        else
                        {
                            isPlayerVisible = false;
                            Debug.DrawLine(transform.position, player.transform.position, Color.red);
                        }
                    }
                }
                else
                {
                    isPlayerVisible = false;
                    Debug.DrawLine(transform.position, player.transform.position, Color.red);
                }

                yield return new WaitForSeconds(visibilityCheckInterval);
            }
        }
    }
}
