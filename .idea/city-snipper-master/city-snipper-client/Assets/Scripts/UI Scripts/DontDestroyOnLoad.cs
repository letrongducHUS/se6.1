using UnityEngine;
using System.Collections;

public class DontDestroyOnLoad : MonoBehaviour {

    static bool created = false;
    // Use this for initialization
    void Awake()
    {
        Debug.Log("Dont destroy : " + gameObject.name);
        if (!created)
        {
            DontDestroyOnLoad(gameObject);
            created = true;
        }
        else
        {
            Destroy(gameObject); // duplicate will be destroyed if 'first' scene is reloaded
        }


    }
}
