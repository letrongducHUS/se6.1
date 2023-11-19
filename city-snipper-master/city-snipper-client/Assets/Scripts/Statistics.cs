using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    public int myscore;
    public Text scores;
    public Text scores1;
    public Text scores2;
    [HideInInspector]
    public Text scores3;

    [HideInInspector]
    public int TotalEnmiies;
    [HideInInspector]
    public Text TotalEnemiess;
    [HideInInspector]
    public Text TotalEnemiess1;
    [HideInInspector]
    public Text TotalEnemiess2;

    [HideInInspector]
    public int KillEnemyCount = 0;
    [HideInInspector]
    public Text KilledEnemies;
    [HideInInspector]
    public Text KilledEnemies1;
    [HideInInspector]
    public Text KilledEnemies2;

    public int headshoottCount = 0;
    public Text HeadShoots;
    public Text HeadShoots1;
    public Text HeadShoots2;


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
            return scores1;
        }

        set
        {
            scores1 = value;
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
        Diamondsadd();
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
        headshoottCount += 1;
        HeadShoots.text = headshoottCount.ToString();
        HeadShoots1.text = headshoottCount.ToString();
        HeadShoots2.text = headshoottCount.ToString();
    }

    public void CoinScore()
    {
        myscore = PlayerPrefs.GetInt("score");
        scores.text = myscore.ToString();
        scores1.text = myscore.ToString();
        scores2.text = myscore.ToString();
      //  scores3.text = myscore.ToString();
    }
    public void TotalEnemies()
    {
        
        TotalEnemiess.text = TotalEnmiies.ToString();
        TotalEnemiess1.text = TotalEnmiies.ToString();
        TotalEnemiess2.text = TotalEnmiies.ToString();

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
