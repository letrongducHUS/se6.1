
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Crouch_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject Crouch;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized10", "true");


        //Zoom
        ButtonPosition[0] = Crouch.transform.position.x;
        ButtonPosition[1] = Crouch.transform.position.y;
        ButtonPosition[2] = Crouch.transform.position.z;
        PlayerPrefs.SetFloat("CrouchX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("CrouchY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("CrouchZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized10");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("CrouchX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("CrouchY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("CrouchZ");
            Crouch.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
