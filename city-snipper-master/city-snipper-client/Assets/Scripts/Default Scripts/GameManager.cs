using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject pnLevelComplete, pnGamePlay, pnGameOver, pnPause, nextButton;
    public LevelManager levelManager;

    bool isCompleted = false;
    bool isOver = false;

    public GameObject levelComp;

    public GameObject GameComp;

    public GameObject music;
    public GameObject settingPanel;
    public GameObject customizationPanel;

    public GameObject m24;
    public GameObject vss142;
    public GameObject minisniper;
    public GameObject Sks;
    public GameObject awmr182;
    public GameObject vss199;
    public GameObject AdsNotAvailable;
    public static GameManager instance;


    // Use this for initialization
    void Start()
    {
        instance = this;
        Time.timeScale = 1;
        AudioListener.pause = false;

        if (!levelManager)
            levelManager = GameObject.FindObjectOfType<LevelManager>();

        PlayerPrefs.SetInt("DailyBonusMultiplePanel", 0);

        if (PlayerPrefs.GetInt("m24") == 1)
        {
            m24.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        /*if (PlayerPrefs.GetInt("vss142") == 1)
        {
            vss142.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("Sks") == 1)
        {
            Sks.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("minisniper") == 1)
        {
            minisniper.GetComponent<WeaponBehavior>().haveWeapon = true;
        }

        if (PlayerPrefs.GetInt("awmr182") == 1)
        {
            awmr182.GetComponent<WeaponBehavior>().haveWeapon = true;
        }
        if (PlayerPrefs.GetInt("vss199") == 1)
        {
            vss199.GetComponent<WeaponBehavior>().haveWeapon = true;
        }*/


        //        SabloSdk.Instance.LogScreen("Level : "+Preferences.Instance.Level);
        //		SabloSdk.Instance.HideBanner ();
    }

    void Awake()
    {
        //		SabloSdk.Instance.ShowSequence (1);
    }


    public void btn_Next()
    {
        if (Preferences.Instance.Level < levelManager.Levels.Length)
            Preferences.Instance.Level++;


        /*if (Preferences.Instance.Level >= 1 && Preferences.Instance.Level <= 8)
        {
            PlayerPrefs.SetInt("EliteMissionPanel", 1);
        }*/
        if ((Preferences.Instance.Level >= 1 && Preferences.Instance.Level <= 8) || Preferences.Instance.Level == 33)
        {
            PlayerPrefs.SetInt("EliteMissionPanel", 1);
        }

        if (Preferences.Instance.Level >= 9 && Preferences.Instance.Level <= 16)
        {
            PlayerPrefs.SetInt("EliteMissionPanel1", 1);
        }

        if (Preferences.Instance.Level >= 17 && Preferences.Instance.Level <= 24)
        {
            PlayerPrefs.SetInt("EliteMissionPanel2", 1);
        }

        if (Preferences.Instance.Level >= 25 && Preferences.Instance.Level <= 33)
        {
            PlayerPrefs.SetInt("RoyaleBattlePanel", 1);
        }

        /*if (Preferences.Instance.Level >= 33 && Preferences.Instance.Level <= 40)
        {
            PlayerPrefs.SetInt("CombatFieldPanel", 1);
        }*/

        if (Preferences.Instance.Level == 10)
        {
            PlayerPrefs.SetInt("level10", 1);
        }

        if (Preferences.Instance.Level == 11)
        {
            PlayerPrefs.SetInt("level11", 1);
        }

        if (Preferences.Instance.Level == 12)
        {
            PlayerPrefs.SetInt("level12", 1);
        }

        if (Preferences.Instance.Level == 13)
        {
            PlayerPrefs.SetInt("level13", 1);
        }

        if (Preferences.Instance.Level == 14)
        {
            PlayerPrefs.SetInt("level14", 1);
        }

        if (Preferences.Instance.Level == 15)
        {
            PlayerPrefs.SetInt("level15", 1);
        }


        if (Preferences.Instance.Level == 16)
        {
            PlayerPrefs.SetInt("level16", 1);
        }

        if (Preferences.Instance.Level == 18)
        {
            PlayerPrefs.SetInt("level18", 1);
        }

        if (Preferences.Instance.Level == 19)
        {
            PlayerPrefs.SetInt("level19", 1);
        }

        if (Preferences.Instance.Level == 20)
        {
            PlayerPrefs.SetInt("level20", 1);
        }

        if (Preferences.Instance.Level == 21)
        {
            PlayerPrefs.SetInt("level21", 1);
        }

        if (Preferences.Instance.Level == 22)
        {
            PlayerPrefs.SetInt("level22", 1);
        }

        if (Preferences.Instance.Level == 23)
        {
            PlayerPrefs.SetInt("level23", 1);
        }

        if (Preferences.Instance.Level == 24)
        {
            PlayerPrefs.SetInt("level24", 1);
        }



        if (Preferences.Instance.Level == 26)
        {
            PlayerPrefs.SetInt("level26", 1);
        }


        if (Preferences.Instance.Level == 27)
        {
            PlayerPrefs.SetInt("level27", 1);
        }

        if (Preferences.Instance.Level == 28)
        {
            PlayerPrefs.SetInt("level28", 1);
        }

        if (Preferences.Instance.Level == 29)
        {
            PlayerPrefs.SetInt("level29", 1);
        }

        if (Preferences.Instance.Level == 30)
        {
            PlayerPrefs.SetInt("level30", 1);
        }


        if (Preferences.Instance.Level == 31)
        {
            PlayerPrefs.SetInt("level31", 1);
        }


        if (Preferences.Instance.Level == 32)
        {
            PlayerPrefs.SetInt("level32", 1);
        }

        if (Preferences.Instance.Level == 33)
        {
            PlayerPrefs.SetInt("level33", 1);
        }

        /*if (Preferences.Instance.Level == 34)
        {
            PlayerPrefs.SetInt("level34", 1);
        }

        if (Preferences.Instance.Level == 35)
        {
            PlayerPrefs.SetInt("level35", 1);
        }

        if (Preferences.Instance.Level == 36)
        {
            PlayerPrefs.SetInt("level36", 1);
        }

        if (Preferences.Instance.Level == 37)
        {
            PlayerPrefs.SetInt("level37", 1);
        }

        if (Preferences.Instance.Level == 38)
        {
            PlayerPrefs.SetInt("level38", 1);
        }

        if (Preferences.Instance.Level == 39)
        {
            PlayerPrefs.SetInt("level39", 1);
        }

        if (Preferences.Instance.Level == 40)
        {
            PlayerPrefs.SetInt("level40", 1);
        }
        */

        if (Preferences.Instance.Level == 33)
        {
            PlayerPrefs.SetInt("level33", 1);
        }


        Application.LoadLevel("MainMenu");

    }

    public void btn_MainMenu()
    {
        Time.timeScale = 1;
        StartCoroutine(lateMenuGo());

    }
    IEnumerator lateMenuGo()
    {

        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel("MainMenu");
    }
    public void btn_Replay()
    {

        //WCSdk.Instance.ShowSequence(0);

        Application.LoadLevel("LoadingScene");

    }
    public void btn_pause()
    {
        Time.timeScale = 0;
        pnGamePlay.SetActive(false);
        pnPause.SetActive(true);
        //AdsManager.instance.ShowRewardedVideo();
        //		SabloSdk.Instance.ShowBanner ();
        //		SabloSdk.Instance.ShowSequence(2);

    }

    public void btn_resume()
    {
        Time.timeScale = 1;
        pnGamePlay.SetActive(true);
        pnPause.SetActive(false);
        //		SabloSdk.Instance.HideBanner ();

    }
    public void btn_moreFun()
    {
        //		Application.OpenURL(SabloSdk.Instance.MoreFunURL());
    }

    public void GameOver()
    {
        if (!isOver)
            isOver = true;
        else
            return;
        Debug.Log("Game Over Fun");
        if (isCompleted)
            return;
        StartCoroutine(waitGameOver());
    }

    public void LevelComplete()
    {
        if (!isCompleted)
            isCompleted = true;
        else
            return;
        Debug.Log("Level Complete Fun");
        if (isOver)
            return;
        StartCoroutine(waitlevelComplete());
    }

    IEnumerator waitlevelComplete()
    {
        Debug.Log("Level Complete");

        //		SabloSdk.Instance.ShowBanner ();
        if (Preferences.Instance.Level == Preferences.Instance.LevelUnlock && Preferences.Instance.LevelUnlock < levelManager.Levels.Length)
        {
            Preferences.Instance.LevelUnlock++;
        }
        //        Time.timeScale = 0;
        pnGamePlay.SetActive(false);
        pnLevelComplete.SetActive(true);
        if (Preferences.Instance.Level >= levelManager.Levels.Length)
        {
            nextButton.SetActive(false);
            GameComp.SetActive(true);
            levelComp.SetActive(false);
        }
        //AdsManager.instance.ShowRewardedVideo();
        yield return new WaitForSeconds(2f);
        //		SabloSdk.Instance.ShowSequence(2);
        AudioListener.pause = true;
    }

    IEnumerator waitGameOver()
    {
        //		SabloSdk.Instance.ShowBanner ();

        pnGameOver.SetActive(true);
        pnGamePlay.SetActive(false);
        //AdsManager.instance.ShowRewardedVideo();
        yield return new WaitForSeconds(2f);
        //		SabloSdk.Instance.ShowSequence(2);

    }

    public void SettingOn()
    {

        settingPanel.SetActive(true);
    }

    public void SetingBack()
    {
        settingPanel.SetActive(false);
        customizationPanel.SetActive(false);
    }

    public void SoundOn()
    {
        music.SetActive(true);
    }

    public void SoundOff()
    {
        music.SetActive(false);
    }

    public void CustomizationOn()
    {
        settingPanel.SetActive(false);
        customizationPanel.SetActive(true);
    }

    public void CustomizationSave()
    {
        // settingPanel.SetActive(true);
        customizationPanel.SetActive(false);
    }

    public void LevelSkip()
    {

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            AdsNotAvailable.SetActive(true);
        }
        else
        {
            if (Advertisements.Instance.IsRewardVideoAvailable())
            {
                PlayerPrefs.SetInt("SkipLevel", 1);
                AdsManager.instance.ShowRewardedVideo();
                
            }
            else
            {
                AdsNotAvailable.SetActive(true);
            }
        }
    }

    public void AdsNotAvai()
    {
        AdsNotAvailable.SetActive(false);
    }

    public void WatchAdsCoins()
    {
        PlayerPrefs.SetInt("WatchaddCoin", 1);
        AdsManager.instance.ShowRewardedVideo();
    }

    public void WatchAdsHealth()
    {
        PlayerPrefs.SetInt("WatchaddHealth", 1);
        AdsManager.instance.ShowRewardedVideo();
    }
}