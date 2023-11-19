using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offcanvas : MonoBehaviour
{
    public GameObject Canvas1;
    public GameObject Canvas2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CanvasSettingOff()
    {
        Canvas2.SetActive(false);
        Canvas1.SetActive(true);
    }
}
