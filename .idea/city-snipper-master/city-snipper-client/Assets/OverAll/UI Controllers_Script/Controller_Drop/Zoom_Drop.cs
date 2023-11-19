using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom_Drop : MonoBehaviour {


    public GameObject Zoom;
  
    float[] ButtonPosition;
	// Use this for initialization
	void Start () {

        GetKey();


    }

	
	// Update is called once per frame
	void Update () {

        GetKey();


    }

    void GetKey()
    {
        ButtonPosition = new float[3];
        string a = PlayerPrefs.GetString("Customized2");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("ZoomX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("ZoomY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("ZoomZ");
            Zoom.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
