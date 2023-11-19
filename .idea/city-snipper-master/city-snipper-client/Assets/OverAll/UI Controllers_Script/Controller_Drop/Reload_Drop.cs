using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload_Drop : MonoBehaviour {


    public GameObject Reload;
  
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
        string a = PlayerPrefs.GetString("Customized8");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("ReloadX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("ReloadY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("ReloadZ");
            Reload.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
