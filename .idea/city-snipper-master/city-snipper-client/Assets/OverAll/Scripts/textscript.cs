using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textscript : MonoBehaviour {

	public GameObject txtimage;
	public float timew8;
	public GameObject parent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (Textw8 ());

	}

	IEnumerator Textw8()
	{
		yield return new WaitForSeconds (timew8);
		txtimage.SetActive (false);
		parent.SetActive (false);
	}



}
