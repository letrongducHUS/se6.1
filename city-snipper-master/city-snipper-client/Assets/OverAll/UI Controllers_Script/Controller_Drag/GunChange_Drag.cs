
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GunChange_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject GunChange;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized3", "true");


        //Zoom
        ButtonPosition[0] = GunChange.transform.position.x;
        ButtonPosition[1] = GunChange.transform.position.y;
        ButtonPosition[2] = GunChange.transform.position.z;
        PlayerPrefs.SetFloat("GunChangeX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("GunChangeY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("GunChangeZ", ButtonPosition[2]);

    }
	// Use this for initialization
	void Start () {

        SetKey();
        //PlayerPrefs.DeleteAll ();

        //button.transform.position = new Vector3 (Xposition, Yposition, Zposition);
        //button.transform.position = new Vector3 (PlayerPrefs.GetFloat ("X"), PlayerPrefs.GetFloat ("Y"), PlayerPrefs.GetFloat ("Z"));
    }
	
	// Update is called once per frame
	void Update () {

        SetKey();

    }

    void SetKey()
    {
        ButtonPosition = new float[3];
        string a = PlayerPrefs.GetString("Customized3");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("GunChangeX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GunChangeY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GunChangeZ");
            GunChange.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
