using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    // public GameObject Enemy;
    public GameObject[] scoreobjects;
    private int curentindex = 0;
    public int score = 0;
    public int currentscore;

    public Text textScore;
    public GameObject HeadShot;
    public static ScoreScript instance;
    // Start is called before the first frame update
    void Start()
    {

        instance = this;
        score = PlayerPrefs.GetInt("score");

        textScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerPrefs.GetInt("score");


        textScore.text = score.ToString();


    }

    public void HeadShots()
    {
        HeadShot.SetActive(true);
        Statistics.instance.Headshots();
    }


    public void NewRandomObject()
    {


        int newIndex = Random.Range(0, scoreobjects.Length);

        scoreobjects[curentindex].SetActive(false);
        curentindex = newIndex;

        scoreobjects[curentindex].SetActive(true);

        Coinsadd();
    }



    public void Coinsadd()

    {

        int newscore = Random.Range(1000, 2000);

        currentscore = newscore;

        score = score + currentscore;
        textScore.text = score.ToString();

        PlayerPrefs.SetInt("score", score);

        currentscore = 0;


    }


}
