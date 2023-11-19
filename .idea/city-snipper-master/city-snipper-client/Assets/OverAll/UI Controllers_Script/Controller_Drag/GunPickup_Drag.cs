
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GunPickup_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject GunPickup;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized4", "true");


        //Zoom
        ButtonPosition[0] = GunPickup.transform.position.x;
        ButtonPosition[1] = GunPickup.transform.position.y;
        ButtonPosition[2] = GunPickup.transform.position.z;
        PlayerPrefs.SetFloat("GunPickupX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("GunPickupY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("GunPickupZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized4");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("GunPickupX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GunPickupY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GunPickupZ");
            GunPickup.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
