
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gernade_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject Gernade;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized11", "true");


        //Zoom
        ButtonPosition[0] = Gernade.transform.position.x;
        ButtonPosition[1] = Gernade.transform.position.y;
        ButtonPosition[2] = Gernade.transform.position.z;
        PlayerPrefs.SetFloat("GernadeX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("GernadeY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("GernadeZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized11");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("GernadeX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("GernadeY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("GernadeZ");
            Gernade.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
