using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDrop_Drop : MonoBehaviour {


    public GameObject GunDrop;
  
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
        string a = PlayerPrefs.GetString("Customized5");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("GunDropX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GunDropY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GunDropZ");
            GunDrop.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
