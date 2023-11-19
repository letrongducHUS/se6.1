
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fire_Drag : MonoBehaviour, IDragHandler {


    public GameObject Fire;

    //bool Customized=false;
    float[] ButtonPosition;

    public void OnDrag(PointerEventData P_Event_Data)
    {
        transform.position = Input.mousePosition;
        PlayerPrefs.SetString("Customized1", "true");
        ButtonPosition[0] = Fire.transform.position.x;
        ButtonPosition[1] = Fire.transform.position.y;
        ButtonPosition[2] = Fire.transform.position.z;
        PlayerPrefs.SetFloat("FireX", ButtonPosition[0]);
        PlayerPrefs.SetFloat("FireY", ButtonPosition[1]);
        PlayerPrefs.SetFloat("FireZ", ButtonPosition[2]);
    }
    // Use this for initialization
    void Start()
    {
        SetKey();
        //button.transform.position = new Vector3 (Xposition, Yposition, Zposition);
        //button.transform.position = new Vector3 (PlayerPrefs.GetFloat ("X"), PlayerPrefs.GetFloat ("Y"), PlayerPrefs.GetFloat ("Z"));
    }

    // Update is called once per frame
    void Update () {

        SetKey();

    }

    void SetKey()
    {
        //PlayerPrefs.DeleteAll ();
        ButtonPosition = new float[3];
        string a = PlayerPrefs.GetString("Customized1");
        if (a == "true")
        {
            ButtonPosition[0] = PlayerPrefs.GetFloat("FireX");
            ButtonPosition[1] = PlayerPrefs.GetFloat("FireY");
            ButtonPosition[2] = PlayerPrefs.GetFloat("FireZ");
            Fire.transform.position = new Vector3(ButtonPosition[0], ButtonPosition[1], ButtonPosition[2]);
        }
    }
}
