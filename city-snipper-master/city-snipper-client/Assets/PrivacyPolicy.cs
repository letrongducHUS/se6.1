using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivacyPolicy : MonoBehaviour
{

    public GameObject PrivacyPolicyPan;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("accept") == 1)
        {
            PrivacyPolicyPan.SetActive(false);
        }
        else
        {
            PrivacyPolicyPan.SetActive(true);
        }

    }

    public void btn_Accept()
    {
        PlayerPrefs.SetInt("accept", 1);
        PrivacyPolicyPan.SetActive(false);
    }

    public void btn_Policy()
    {
        Application.OpenURL("https://www.dropbox.com/scl/fi/3yby3cgq66wmqgxotbtvr/privcy-policy.docx?dl=0&rlkey=w78s0adifael8m24gaxnw83md");
    }
}
