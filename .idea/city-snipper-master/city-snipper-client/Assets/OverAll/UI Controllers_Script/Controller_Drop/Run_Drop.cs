using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Drop : MonoBehaviour {


    public GameObject Run;
  
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
        string a = PlayerPrefs.GetString("Customized9");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("RunX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("RunY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("RunZ");
            Run.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
