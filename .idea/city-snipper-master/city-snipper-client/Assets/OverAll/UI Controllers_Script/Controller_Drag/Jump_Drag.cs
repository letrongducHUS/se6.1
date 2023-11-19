
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jump_Drag : MonoBehaviour, IDragHandler {


	
    public GameObject Jump;
  
    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data) {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized6", "true");


        //Zoom
        ButtonPosition[0] = Jump.transform.position.x;
        ButtonPosition[1] = Jump.transform.position.y;
        ButtonPosition[2] = Jump.transform.position.z;
        PlayerPrefs.SetFloat("JumpX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("JumpY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("JumpZ", ButtonPosition[2]);

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
        string a = PlayerPrefs.GetString("Customized6");
        if (a == "true")
        {

            //Zoom
            ButtonPosition[0] = PlayerPrefs.GetFloat("JumpX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("JumpY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("JumpZ");
            Jump.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);


        }
    }
}
