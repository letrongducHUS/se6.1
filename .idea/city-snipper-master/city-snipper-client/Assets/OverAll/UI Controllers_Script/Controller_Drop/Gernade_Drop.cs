using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gernade_Drop : MonoBehaviour {


    public GameObject Gernade;
  
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
        string a = PlayerPrefs.GetString("Customized11");
        if (a == "true")
        {
            Debug.Log(a);

            //Fire
            ButtonPosition[0] = PlayerPrefs.GetFloat("GernadeX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GernadeY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GernadeZ");
            Gernade.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);

        }
    }
}
