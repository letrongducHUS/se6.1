
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GunDrop_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject GunDrop;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized5", "true");


        //Zoom
        ButtonPosition[0] = GunDrop.transform.position.x;
        ButtonPosition[1] = GunDrop.transform.position.y;
        ButtonPosition[2] = GunDrop.transform.position.z;
        PlayerPrefs.SetFloat("GunDropX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("GunDropY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("GunDropZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized5");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("GunDropX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GunDropY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GunDropZ");
            GunDrop.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
