using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Drop : MonoBehaviour {


    public GameObject Jump;
  
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
        string a = PlayerPrefs.GetString("Customized6");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("JumpX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("JumpY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("JumpZ");
            Jump.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
