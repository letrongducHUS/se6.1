using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour 
{

    public GameObject[] tutorials;
    int count = 0;

	void Start () 
    {
        count = 0;
        tutorials[count].SetActive(true);
	
	}

    public void CharacterMove()
    {
        Debug.Log("First Click"+ Preferences.Instance.Level);
        if (Preferences.Instance.Level == 1 && count == 0)
        {
            tutorials[count].SetActive(false);
            count = 1;
            StartCoroutine(WaitNextMessage(1));
        }
    }

    public void CharacterRotate()
    {
        if (Preferences.Instance.Level == 1 && count == 1)
        {
            tutorials[count].SetActive(false);
            count = 2;
            StartCoroutine(WaitNextMessage(1));
        }
    }

    public void PickUpCar()
    {
        if (Preferences.Instance.Level == 1 && count == 2)
        {
            tutorials[count].SetActive(false);
            count = 3;
            StartCoroutine(WaitNextMessage(1));
        }
    }

    public void GunAimSet()
    {
        if (Preferences.Instance.Level == 1 && count == 3)
        {
            tutorials[count].SetActive(false);
            count = 4;
            StartCoroutine(WaitNextMessage(1));
        }
    }
    public void ShootFire()
    {
        if (Preferences.Instance.Level == 1 && count == 4)
        {
            tutorials[count].SetActive(false);
            count = 5;
            StartCoroutine(WaitNextMessage(1));
        }
    }
    public void PlayerHealth()
    {
        if (Preferences.Instance.Level == 1 && count == 5)
        {
            tutorials[count].SetActive(false);
            count = 6;
            StartCoroutine(WaitNextMessage(1));
        }
    }
    public void MissionHelp()
    {
        if (Preferences.Instance.Level == 1 && count == 6)
        {
            tutorials[count].SetActive(false);
            count = 7;
            StartCoroutine(WaitNextMessage(1));
        }
    }

    public void MissionKey()
    {
        if (Preferences.Instance.Level == 1 && count == 7)
        {
            tutorials[count].SetActive(false);
            count = 8;
            StartCoroutine(WaitNextMessage(1));
        }
    }

    public void Radar()
    {
        if (Preferences.Instance.Level == 1 && count == 8)
        {
            tutorials[count].SetActive(false);
            count = 9;
            StartCoroutine(WaitNextMessage(1));
        }
    }

    IEnumerator WaitNextMessage(int t)
    {
        yield return new WaitForSeconds(t);
        if (count == 9)
        {
            GameObject.FindObjectOfType<MissionAI>().MissionDone();
        }
        else
        {
            tutorials[count].SetActive(true);
        }
    }
}
