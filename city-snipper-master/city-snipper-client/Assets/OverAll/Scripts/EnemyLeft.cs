using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLeft : MonoBehaviour {

	public int enemiesLeft = 0;
	bool killedAllEnemies = false;
	public GameObject[] enemies;
	//public Text drawtotalenemies;
	public int enterTotalEnimes;
	public Text finalEnemyShowText;
	public int myenemiesleft;
	//public Text enemiesleftingame;


	public static EnemyLeft instance;

	void Awake()
	{
		instance = this;
	}


	// Use this for initialization
	void Start () {
		//PlayerPrefs.DeleteAll ();

		myenemiesleft = enterTotalEnimes;
		
	}
	
	// Update is called once per frame
	void Update () {

		enemies = GameObject.FindGameObjectsWithTag("Flesh");
		enemiesLeft = enemies.Length;
		if(myenemiesleft == 0)
		{
            StartCoroutine(levelcom());
		}

		if (myenemiesleft <= 0) {
			myenemiesleft = 0;
		}


		finalEnemyShowText.text = myenemiesleft.ToString () + "/" + enterTotalEnimes.ToString ();



	}

    IEnumerator levelcom()
    {
        yield return new WaitForSeconds(1.5f);
        GameManager.instance.LevelComplete();
    }
}
