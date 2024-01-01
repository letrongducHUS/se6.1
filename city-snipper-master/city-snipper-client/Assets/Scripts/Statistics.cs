using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public int myscore;
    public Text scores;
    public Text scores1;
    public Text scores2;
    [HideInInspector]
    public int setScore;

    [HideInInspector]
    public int totalEnemies;
    [HideInInspector]
    public Text TotalEnemiess;
    [HideInInspector]
    public Text TotalEnemiess1;
    [HideInInspector]
    public Text TotalEnemiess2;

    public int BodyShots = 0;
    public Text BodyShot;
    public Text BodyShot1;
    public Text BodyShot2;

    [HideInInspector]
    public int KillEnemyCount = 0;
    [HideInInspector]
    public Text KilledEnemies;
    [HideInInspector]
    public Text KilledEnemies1;
    [HideInInspector]
    public Text KilledEnemies2;

    public int HeadShots = 0;
    public Text HeadShot;
    public Text HeadShot1;
    public Text HeadShot2;


    [HideInInspector]
    public int Dimaoondscore = 0;
    [HideInInspector]
    public int Diamonndcurrentscore;
    [HideInInspector]
    public Text DiamondScore;
    [HideInInspector]
    public Text DiamondScore1;
    [HideInInspector]
    public Text DiamondScore2;

    private int dimaonds;


    public static Statistics instance;

    public Text Scores1
    {
        get
        {
            return scores;
        }

        set
        {
            scores = value;
        }
    }
    
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        CoinScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void killingEnemies()
    {
        KillEnemyCount += 1;
        CoinScore();
        KilledEnemies.text = KillEnemyCount.ToString();
        KilledEnemies1.text = KillEnemyCount.ToString();
        KilledEnemies2.text = KillEnemyCount.ToString();

    }

    public void Headshots()
    {   
        PlayerPrefs.SetInt("PreviusHeadShots", HeadShots);
        HeadShots += 1;
        HeadShot.text = (HeadShots).ToString();
        HeadShot1.text = (HeadShots).ToString();
        HeadShot2.text = (HeadShots).ToString();
        
    }
    public void BodyHitsCount(int headShot)
    {

        BodyShots += 1;
        BodyShots -= headShot;
        if (BodyShots < 0) { BodyShots = 0; }
        BodyShot.text = BodyShots.ToString();
        BodyShot1.text = BodyShots.ToString();
        BodyShot2.text = BodyShots.ToString();
        PlayerPrefs.SetInt("BodyShots", 0);
    }
    public void CoinScore()
    { 
        //  PlayerPrefs.SetInt("score", setScore);
        myscore = PlayerPrefs.GetInt("score");
        scores.text = myscore.ToString();
        scores1.text = myscore.ToString();
        scores2.text = myscore.ToString();
        //  scores3.text = myscore.ToString();
    }
    public void TotalEnemies()
    {

        TotalEnemiess.text = totalEnemies.ToString();
        TotalEnemiess1.text = totalEnemies.ToString();
        TotalEnemiess2.text = totalEnemies.ToString();

    }

    public void Diamondsadd()

    {

        int newscore = Random.Range(1, 2);

        Diamonndcurrentscore = newscore;

        Dimaoondscore = Dimaoondscore + Diamonndcurrentscore;


        PlayerPrefs.SetInt("diamond", Dimaoondscore);

        dimaonds = PlayerPrefs.GetInt("diamond");


        //  DiamondScore.text = dimaonds.ToString();
        //  DiamondScore1.text = dimaonds.ToString();
        //  DiamondScore2.text = dimaonds.ToString();

        //  Diamonndcurrentscore = 0;


    }
}
