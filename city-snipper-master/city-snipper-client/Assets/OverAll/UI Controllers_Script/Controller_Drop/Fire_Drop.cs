using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Drop : MonoBehaviour {


    public GameObject Fire;
  
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
        string a = PlayerPrefs.GetString("Customized1");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("FireX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("FireY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("FireZ");
            Fire.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
