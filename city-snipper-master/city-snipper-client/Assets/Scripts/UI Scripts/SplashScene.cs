using UnityEngine;
using System.Collections;

public class SplashScene : MonoBehaviour {

	// Use this for initialization
	void Start () {

        PlayerPrefs.SetInt("DailyBonusMultiplePanel", 1);
        LevelSelection.startDialog();
        StartCoroutine(lateStart());

	}
	
	// Update is called once per frame
	IEnumerator lateStart() {

        yield return new WaitForSeconds(3f);
//		SabloSdk.Instance.ShowBanner ();
        Application.LoadLevel("MainMenu");
	}
}
