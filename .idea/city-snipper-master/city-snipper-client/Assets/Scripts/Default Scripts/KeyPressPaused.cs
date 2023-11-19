using UnityEngine;
using System.Collections;

public class KeyPressPaused : MonoBehaviour {

    public KeyCode motionSlow0 = KeyCode.Alpha7;
    public KeyCode motionSlow1 = KeyCode.Alpha8;
    public KeyCode motionMedium = KeyCode.Alpha9;
    public KeyCode motionFast = KeyCode.Alpha0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(motionSlow0))
            Time.timeScale = 0;
        else if (Input.GetKeyDown(motionSlow1))
            Time.timeScale = 0.05f;
        else if (Input.GetKeyDown(motionMedium))
            Time.timeScale = 0.3f;
        else if (Input.GetKeyDown(motionFast))
            Time.timeScale = 1f;
	
	}
}
