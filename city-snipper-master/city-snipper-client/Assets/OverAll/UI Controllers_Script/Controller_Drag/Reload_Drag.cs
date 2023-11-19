
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Reload_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject Reload;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized8", "true");


        //Zoom
        ButtonPosition[0] = Reload.transform.position.x;
        ButtonPosition[1] = Reload.transform.position.y;
        ButtonPosition[2] = Reload.transform.position.z;
        PlayerPrefs.SetFloat("ReloadX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("ReloadY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("ReloadZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized8");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("ReloadX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("ReloadY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("ReloadZ");
            Reload.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
