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

namespace DarkTreeFPS
{
    public class Sway : MonoBehaviour
    {
        [Tooltip("Sway smooth amount")]
        public float smooth = 2.0f;
        
        public float xSwayAmount = 0.1f;
        public float ySwayAmount = 0.1f;

        [Tooltip("Max allowed value for sway amount")]
        public float maxXAmount = 0.35f;
        [Tooltip("Max allowed value for sway amount")]
        public float maxYAmount = 0.2f;

        public float startX, startY;

        //Local position of an object on start used for further calculations
        private Vector3 localPos;
        
        void Start()
        {
            localPos = transform.localPosition;
            startX = xSwayAmount;
            startY = ySwayAmount;
        }
        
        void Update()
        {
            float fx = new float() , fy = new float();

            //Sway coefficient got from mouse input multyplied on swayAmmount for each axis
            if (!InputManager.useMobileInput)
            {
                fx = -Input.GetAxis("Mouse X") * xSwayAmount;
                fy = -Input.GetAxis("Mouse Y") * ySwayAmount;
            }

            if(InputManager.useMobileInput)
            {
                fx = -InputManager.touchPanelLook.x * Time.deltaTime * xSwayAmount;
                fy = -InputManager.touchPanelLook.y * Time.deltaTime * ySwayAmount;
            }

            if (fx > maxXAmount)
                fx = maxXAmount;

            if (fx < -maxXAmount)
                fx = -maxXAmount;

            if (fy > maxYAmount)
                fy = maxYAmount;

            if (fy < -maxYAmount)
                fy = -maxYAmount;
            
            //Calculating sway vector 
            Vector3 swayVector = new Vector3(localPos.x + fx, localPos.y + fy, localPos.z);

            //Applying sway Vector to object local position
            transform.localPosition = Vector3.Lerp(transform.localPosition, swayVector , Time.deltaTime * smooth);
        }
        
    }
}
