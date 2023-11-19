
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Zoom_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject Zoom;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized2", "true");


        //Zoom
        ButtonPosition[0] = Zoom.transform.position.x;
        ButtonPosition[1] = Zoom.transform.position.y;
        ButtonPosition[2] = Zoom.transform.position.z;
        PlayerPrefs.SetFloat("ZoomX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("ZoomY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("ZoomZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized2");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("ZoomX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("ZoomY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("ZoomZ");
            Zoom.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
