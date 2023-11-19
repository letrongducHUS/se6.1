using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textoffscript : MonoBehaviour {

	public GameObject txt;

	public static textoffscript instance;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {

		StartCoroutine (txtoff ());


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator txtoff()
	{
		yield return new WaitForSeconds (0.8f);
		txt.SetActive (false);
	}
}
