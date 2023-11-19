using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    public GameObject[] Levels;

    public GameObject Player;
    public bool respawnPlayer = false;
    public GameObject[] playerSpawns;
    int curLevel;

    [Header("Only for Testing Levels")]
    public bool testLevel = false;
    public int testLevelNum = 1;
    public Text MissionNo1;
    public Text MissionNo2;
    public Text MissionNo3;
    void Start()
    {
        //Preferences.Instance.Reset ();
        if (testLevel)
        {
            curLevel = testLevelNum;
            Preferences.Instance.Level = testLevelNum;
        }
        else
            curLevel = Preferences.Instance.Level;

        MissionNo1.text = curLevel.ToString();
        MissionNo2.text = curLevel.ToString();
        MissionNo3.text = curLevel.ToString();

        if (Player && respawnPlayer)
        {
            Player.transform.position = playerSpawns[curLevel - 1].transform.position;
            Player.transform.rotation = playerSpawns[curLevel - 1].transform.rotation;
        }

        Levels[curLevel - 1].SetActive(true);

        Debug.Log("level " + Preferences.Instance.Level);
    }
}
