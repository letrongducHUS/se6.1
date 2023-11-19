using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdsManager : MonoBehaviour
{
    public static AdsManager instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        Advertisements.Instance.SetUserConsent(true);
        if (Advertisements.Instance.UserConsentWasSet())
        {
            Advertisements.Instance.Initialize();
        }
    }
    public void ShowBanner()
    {
        //Advertisements.Instance.ShowBanner(BannerPosition.TOP);
    }

    public void HideBanner()
    {
        Advertisements.Instance.HideBanner();
    }

    public void ShowInterstitial()
    {
        Advertisements.Instance.ShowInterstitial();
    }
    public void ShowRewardedVideo()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GamePlay"))
            {
                //Nothing to do here
                Debug.Log("InternetNotConnected");
            }
            else
            {
                Debug.Log("InternetNotConnected1");
                MainMenuUI.instance.InternetnotAVAIL();
            }

        }
        else
        {
            if (Advertisements.Instance.IsRewardVideoAvailable())
            {
                Advertisements.Instance.ShowRewardedVideo(CompleteMethod);
            }
            else
            {
                PlayerPrefs.SetInt("SkipLevel", 0);
                PlayerPrefs.SetInt("WatchaddCoin", 0);
                PlayerPrefs.SetInt("WatchaddHealth", 0);
                PlayerPrefs.SetInt("WatchaddGrenade", 0);
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GamePlay"))
                {
                    //Nothing to do here
                    Debug.Log("AdsNotAvailable");
                }
                else
                {
                    MainMenuUI.instance.adnotavailable();
                }

            }
        }
    }
    private void CompleteMethod(bool completed)
    {
        if (completed)
        {
            //Reward the Player
            Debug.Log("PlayerRewarded");
            if (PlayerPrefs.GetInt("WatchaddCoin") == 1)
            {
                DeductionMoney.instance.GiveCoin(1000);
                PlayerPrefs.SetInt("WatchaddCoin", 0);
                MainMenuUI.instance.Thousndcoin();
            }

            if (PlayerPrefs.GetInt("WatchaddHealth") == 1)
            {
                DeductionMoney.instance.TransferHealth(1);
                PlayerPrefs.SetInt("WatchaddHealth", 0);
                MainMenuUI.instance.OneHEALTH();
            }

            if (PlayerPrefs.GetInt("WatchaddGrenade") == 1)
            {
                DeductionMoney.instance.GiveGrenade(1);
                PlayerPrefs.SetInt("WatchaddGrenade", 0);
                MainMenuUI.instance.OneGrenade();
            }
            if (PlayerPrefs.GetInt("SkipLevel") == 1)
            {
                PlayerPrefs.SetInt("SkipLevel", 0);
                GameManager.instance.LevelComplete();
            }
        }

        else
        {
            PlayerPrefs.SetInt("SkipLevel", 0);
            PlayerPrefs.SetInt("WatchaddCoin", 0);
            PlayerPrefs.SetInt("WatchaddHealth", 0);
            PlayerPrefs.SetInt("WatchaddGrenade", 0);
        }
    }
}
