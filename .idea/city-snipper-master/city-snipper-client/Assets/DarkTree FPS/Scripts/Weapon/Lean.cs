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

    public class Lean : MonoBehaviour
    {
        InputManager inputManager;

        [Header("Lean Settings")]
        public float leanRotationSpeed = 80f;
        public float leanPositionSpeed = 3f;
        public float maxAngle = 30f;
        public float leanPositionShift = 0.1f;

        private float leanCurrentAngle = 0f;
        private float leanCurrentPosition;
        Quaternion leanRotation;

        Vector3 velocity = Vector3.zero;

        public float checkCollisionDistance = 0.1f;

        private void Start()
        {
            inputManager = FindObjectOfType<InputManager>();
        }

        void Update()
        {
            if (Input.GetKey(inputManager.LeanLeft))
            {
                RaycastHit hit;

                if (!Physics.Raycast(transform.position, -transform.right, out hit, checkCollisionDistance)){
                    var temp_leanPositionShift = leanPositionShift;
                    leanCurrentAngle = Mathf.MoveTowardsAngle(leanCurrentAngle, maxAngle, leanRotationSpeed * Time.smoothDeltaTime);
                    transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(-temp_leanPositionShift, 0, 0), ref velocity, leanPositionSpeed * Time.smoothDeltaTime);
                }else
                {
                    var temp_leanPositionShift = Vector3.Distance(transform.position, hit.point)/1.5f;
                    leanCurrentAngle = Mathf.MoveTowardsAngle(leanCurrentAngle, maxAngle/3, leanRotationSpeed * Time.smoothDeltaTime);
                    transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(-temp_leanPositionShift, 0, 0), ref velocity, leanPositionSpeed * Time.smoothDeltaTime);
                }

            }
            else if (Input.GetKey(inputManager.LeanRight))
            {
                RaycastHit hit;

                if (!Physics.Raycast(transform.position, transform.right, out hit, checkCollisionDistance))
                {
                    var temp_leanPositionShift = leanPositionShift;
                    leanCurrentAngle = Mathf.MoveTowardsAngle(leanCurrentAngle, -maxAngle, leanRotationSpeed * Time.smoothDeltaTime);
                    transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(temp_leanPositionShift, 0, 0), ref velocity, leanPositionSpeed * Time.smoothDeltaTime);
                }
                else
                {
                    var temp_leanPositionShift = Vector3.Distance(transform.position, hit.point) / 1.5f;
                    leanCurrentAngle = Mathf.MoveTowardsAngle(leanCurrentAngle, -maxAngle / 3, leanRotationSpeed * Time.smoothDeltaTime);
                    transform.localPosition = Vector3.SmoothDamp(transform.localPosition, new Vector3(temp_leanPositionShift, 0, 0), ref velocity, leanPositionSpeed * Time.smoothDeltaTime);
                }
            }
            else
            {
                leanCurrentAngle = Mathf.MoveTowardsAngle(leanCurrentAngle, 0f, leanRotationSpeed * Time.deltaTime);
                transform.localPosition = Vector3.SmoothDamp(transform.localPosition, Vector3.zero, ref velocity, leanPositionSpeed * Time.smoothDeltaTime);
            }

            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, leanCurrentAngle));
            
        }
    }
}
