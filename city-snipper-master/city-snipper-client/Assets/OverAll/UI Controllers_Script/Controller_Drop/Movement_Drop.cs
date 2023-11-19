using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Drop : MonoBehaviour {


    public GameObject Movement;
  
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
        string a = PlayerPrefs.GetString("Customized7");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("MovementX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("MovementY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("MovementZ");
            Movement.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
