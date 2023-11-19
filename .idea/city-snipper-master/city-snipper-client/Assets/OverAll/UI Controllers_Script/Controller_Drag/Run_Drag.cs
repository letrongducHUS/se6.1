
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Run_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject Run;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized9", "true");


        //Zoom
        ButtonPosition[0] = Run.transform.position.x;
        ButtonPosition[1] = Run.transform.position.y;
        ButtonPosition[2] = Run.transform.position.z;
        PlayerPrefs.SetFloat("RunX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("RunY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("RunZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized9");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("RunX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("RunY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("RunZ");
            Run.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
