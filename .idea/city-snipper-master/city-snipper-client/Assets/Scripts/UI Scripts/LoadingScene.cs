using UnityEngine;
using System.Collections;

public class LoadingScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        LevelSelection.startDialog();
        Application.LoadLevel("GamePlay");
        
	}

	
}
