using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch_Drop : MonoBehaviour {


    public GameObject Crouch;
  
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
        string a = PlayerPrefs.GetString("Customized10");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("CrouchX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("CrouchY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("CrouchZ");
            Crouch.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
