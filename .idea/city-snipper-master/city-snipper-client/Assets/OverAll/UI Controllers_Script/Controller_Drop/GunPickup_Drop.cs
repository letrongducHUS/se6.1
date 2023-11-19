using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup_Drop : MonoBehaviour {


    public GameObject GunPickup;
  
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
        string a = PlayerPrefs.GetString("Customized4");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("GunPickupX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GunPickupY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GunPickupZ");
            GunPickup.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
