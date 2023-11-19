
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject Movement;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized7", "true");


        //Zoom
        ButtonPosition[0] = Movement.transform.position.x;
        ButtonPosition[1] = Movement.transform.position.y;
        ButtonPosition[2] = Movement.transform.position.z;
        PlayerPrefs.SetFloat("MovementX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("MovementY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("MovementZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized7");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("MovementX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("MovementY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("MovementZ");
            Movement.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
