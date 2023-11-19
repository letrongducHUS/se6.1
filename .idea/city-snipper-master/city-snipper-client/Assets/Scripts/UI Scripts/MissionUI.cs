using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MissionUI : MonoBehaviour 
{
    public Text txtMission;
    public GameObject panelMission;
    public string[] missions;

	// Use this for initialization
	void Start () 
    {
	//	panelMission.SetActive(true);
      //  txtMission.text = missions[Preferences.Instance.Level - 1];
	
	}


    public void btnCloseBriefing()
    {
        Time.timeScale = 1;
        panelMission.SetActive(false);
    }
    public void btnOpenBriefing()
    {
        Time.timeScale = 0;
        panelMission.SetActive(true);
    }
}
