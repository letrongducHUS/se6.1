using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChange_Drop : MonoBehaviour {


    public GameObject GunChange;
  
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
        string a = PlayerPrefs.GetString("Customized3");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("GunChangeX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GunChangeY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GunChangeZ");
            GunChange.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
