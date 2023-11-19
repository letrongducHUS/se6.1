/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using UnityEditor;

public class EditorFields : Editor
{
    public static void DrawLabel(string text)
    {
        GUILayout.Label(text);
    }

    public static void DrawInt(int value)
    {
        value = EditorGUILayout.IntField(value);
    }

    public static void DrawFloat(float value)
    {
        value = EditorGUILayout.FloatField(value);
    }

    public static void DrawString(string text)
    {
        text = EditorGUILayout.TextField(text);
    }

    public static void DrawObject(Object obj, bool allowSceneObjects)
    {
        obj = (Object)EditorGUILayout.ObjectField(obj, typeof(Object), false);
    }
}
