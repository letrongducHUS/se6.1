using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Mission
{
    Mission1,
    Mission2,
    Mission3,
    Mission4,
    Mission5,
    Mission6
}
public class MissionAI : MonoBehaviour 
{

    public Mission mission;
    int enemiesToKill = 0;
	public GameObject btnWeapon;
	[Header("Only for Mission 2")]
	public Collider carSpecialCollider;
	public Text txtTimer;
	int timer=0;
	[Header("Only for Mission 3")]
	public GameObject moveJoystick;
    [Header("Only for Mission 5")]
    public GameObject timeBomb;
    public GameObject explosion;
	public GameObject explosionObjects;
    public GameObject pnBlood;
	// Use this for initialization
	void Start () 
    {

        switch (mission)
        {
            case Mission.Mission1:

                break;
            case Mission.Mission2:
			btnWeapon.SetActive(false);
			txtTimer.transform.parent.gameObject.SetActive (true);
			timer=30;
			InvokeRepeating("timeClock",2f,1f);

			StartCoroutine(assignCarSpecial());

                break;
            case Mission.Mission3:
                StartCoroutine(assignSniper());
                enemiesToKill = GameObject.FindGameObjectsWithTag("Soldier").Length;
				moveJoystick.SetActive(false);
                //StartCoroutine(assignBomb());
                break;
            case Mission.Mission4:
				txtTimer.transform.parent.gameObject.SetActive (true);
				timer=120;
				InvokeRepeating("timeClock",2f,1f);
//                StartCoroutine(assignBomb());
                break;
            case Mission.Mission5:
				btnWeapon.SetActive(false);
                StartCoroutine(assignBomb());
                break;
            case Mission.Mission6:
                StartCoroutine(assignSniper());
                enemiesToKill = GameObject.FindGameObjectsWithTag("Soldier").Length;
                break;
        }
	
	}
	public void MissionDone()
	{
		switch (mission)
		{
		case Mission.Mission1:
			GameObject.FindObjectOfType<GameManager>().LevelComplete();
			break;
		case Mission.Mission2:
			
			GameObject.FindObjectOfType<GameManager>().LevelComplete();
			Debug.Log("Mission DOne");
			
			break;
		case Mission.Mission3:
			enemiesToKill -= 1;
			if (enemiesToKill <= 0)
			{
				GameObject.FindObjectOfType<GameManager>().LevelComplete();
				Debug.Log("Mission DOne");
			}
			break;
		case Mission.Mission4:
			GameObject.FindObjectOfType<GameManager>().LevelComplete();
			break;
		case Mission.Mission5:
			
			StartCoroutine(placingBomb());
			break;
		case Mission.Mission6:
			enemiesToKill -= 1;
			if (enemiesToKill <= 0)
			{
				GameObject.FindObjectOfType<GameManager>().LevelComplete();
				Debug.Log("Mission DOne");
			}
			
			break;
		}
	}

	void timeClock()
	{
		timer -= 1;
		txtTimer.text = timer.ToString();
		if (timer <= 0) {
			GameObject.FindObjectOfType<GameManager> ().GameOver ();
		}
	}
	IEnumerator assignCarSpecial()
	{
		yield return new WaitForSeconds (0.5f);
		Debug.Log ("car special assigning");
		carSpecialCollider.gameObject.SendMessage("Action", SendMessageOptions.DontRequireReceiver);
	}
    IEnumerator assignSniper()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < 4; i++)
        {
        }
    }
    IEnumerator assignBomb()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < 2; i++)
        {
        }
    }
    
    bool once = false;


    IEnumerator placingBomb()
    {
        if (!once)
        {
            once = true;
            GameObject.Find("_Time_Bomb").SetActive(false);
            GameObject _bombPlacingPosition = GameObject.Find("_bombPlacingPosition");
            GameObject go = Instantiate(timeBomb, _bombPlacingPosition.transform.position, _bombPlacingPosition.transform.rotation) as GameObject;
            go.transform.localScale = new Vector3(1, 1, 1);

            yield return new WaitForSeconds(15f);
			DestroyImmediate(timeBomb,true);
            Instantiate(explosion, _bombPlacingPosition.transform.position, _bombPlacingPosition.transform.rotation);
            //level 5 explosion
			Transform[] childs=explosionObjects.GetComponentsInChildren<Transform>();
			foreach(Transform i in childs)
			{
				i.gameObject.AddComponent<Rigidbody>();
				i.GetComponent<Rigidbody>().drag=1f;
			}

			yield return new WaitForSeconds(4f);
            if (Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, _bombPlacingPosition.transform.position) < 8)
            {
				pnBlood.SetActive(true);
                GameObject.FindObjectOfType<GameManager>().GameOver();
            }
            else
				GameObject.FindObjectOfType<GameManager>().LevelComplete();
            
        }
    }
    
}
