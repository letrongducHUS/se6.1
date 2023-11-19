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
using UnityEngine.EventSystems;

namespace DarkTreeFPS.MobileInput
{
    public class Joystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
    {
        [Header("Options")]
        [Range(0f, 2f)] public float handleLimit = 1f;

        public static Vector2 inputVector = Vector2.zero;

        [Header("Components")]
        public RectTransform background;
        public RectTransform handle;

        public float Horizontal { get { return inputVector.x; } }
        public float Vertical { get { return inputVector.y; } }
        public Vector2 Direction { get { return new Vector2(Horizontal, Vertical); } }

        Vector2 joystickPosition = Vector2.zero;
        private Camera cam = new Camera();

        void Start()
        {
            joystickPosition = RectTransformUtility.WorldToScreenPoint(cam, background.position);
        }

        public virtual void OnDrag(PointerEventData eventData)
        {
            Vector2 direction = eventData.position - joystickPosition;
            inputVector = (direction.magnitude > background.sizeDelta.x / 2f) ? direction.normalized : direction / (background.sizeDelta.x / 2f);
            handle.anchoredPosition = (inputVector * background.sizeDelta.x / 2f) * handleLimit;
            InputManager.joystickInputVector = inputVector;
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            OnDrag(eventData);
        }

        public virtual void OnPointerUp(PointerEventData eventData)
        {
            inputVector = Vector2.zero;
            InputManager.joystickInputVector = inputVector;
            handle.anchoredPosition = Vector2.zero;
        }
    }
}
