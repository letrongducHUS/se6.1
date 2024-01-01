using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeductionMoney : MonoBehaviour
{

   
    int Grenade;

    [HideInInspector]
    public bool isGrenade;
    public bool isHealth;
    public bool isGunPanel;


    [HideInInspector]
    public GameObject GrenadesPanel;
    public GameObject HealthPanel;
    public GameObject GunPanel;

    int coin;
    public static DeductionMoney instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
       
       if (HealthPanel.activeInHierarchy == true)
        {
            isHealth = true;
        }
       else if (GunPanel.activeInHierarchy == true)
        {
            isGunPanel = true;
        }
        else {
           
            isGrenade = false;
            isHealth = false;
            isGunPanel = false;
        }

        if (PlayerPrefs.GetInt("score") <= 0)
        {

            PlayerPrefs.SetInt("score", 0);
        }
    }

    public void DeductCoin (int value)
    {

        coin = PlayerPrefs.GetInt("score");

            
            if (isGrenade)
            {

                
                if (value == 500)
                {

                    if (PlayerPrefs.GetInt("score") >=500)
                    {
                        coin -= value;
                        GiveGrenade(1);
                    }
                  
                }
                if (value == 1000)
                {
                    if ( PlayerPrefs.GetInt("score") >= 1000)
                    {
                        coin -= value;
                        GiveGrenade(2);
                    }
                        
                }

                if (value == 2000)
                {

                    if ( PlayerPrefs.GetInt("score") >= 2000)
                    {
                        coin -= value;
                        GiveGrenade(3);
                    }
                      

                }

                if (value == 4000)
                {

                    if (PlayerPrefs.GetInt("score") >= 4000)
                    {
                        coin -= value;
                        GiveGrenade(4);
                    }
                   
                }
            }

            if (isHealth)
            {
             
                if (value == 1000)
                {

                    if (PlayerPrefs.GetInt("score") >= 1000)
                    {
                        coin -= value;
                        TransferHealth(2);
                    }
                }

                if (value == 2000)
                {
                    if (PlayerPrefs.GetInt("score") >= 2000)
                    {
                        coin -= value;
                        TransferHealth(3);
                    }
                }

                if (value == 3000)
                {

                    if (PlayerPrefs.GetInt("score") >= 3000)
                    {
                        coin -= value;
                        TransferHealth(4);
                    }
                }
            }



        if (isGunPanel)
        {

            if (value == 1000)
            {
                if (PlayerPrefs.GetInt("score") >= 1000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("m24", 1);
                }
            }
            if (value == 1500)
            {

                if (PlayerPrefs.GetInt("score") >= 1500)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("Sks", 1);
                }
            }

            if (value == 2000)
            {
                if (PlayerPrefs.GetInt("score") >= 2000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("minisniper", 1);
                }
            }

            if (value == 3000)
            {

                if (PlayerPrefs.GetInt("score") >= 3000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("vss142", 1);
                }
            }

            if (value == 4000)
            {

                if (PlayerPrefs.GetInt("score") >= 4000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("awmr182", 1);
                }
            }

            if (value == 5000)
            {

                if (PlayerPrefs.GetInt("score") >= 5000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("vss199", 1);
                }
            }

            if (value == 6000)
            {

                if (PlayerPrefs.GetInt("score") >= 6000)
                {
                    coin -= value;
                    PlayerPrefs.SetInt("l96a1", 1);
                }
            }
        }


        PlayerPrefs.SetInt("score", coin);

       
       
    }

   
   public void GiveCoin(int value)
    {
        if (PlayerPrefs.GetInt("score") != null)
        {
            int getscore = PlayerPrefs.GetInt("score");

            getscore += value;

            PlayerPrefs.SetInt("score", getscore);
        }
        else
        {
            PlayerPrefs.SetInt("score", value);
        }
    }

    public void TransferHealth(int value)
    {
        if (PlayerPrefs.GetInt("GiveHealth") != null)
        {
            int totalhealthgive;

            totalhealthgive = PlayerPrefs.GetInt("GiveHealth");

            totalhealthgive += value;

            PlayerPrefs.SetInt("GiveHealth", totalhealthgive);
        }
        else
        {
            PlayerPrefs.SetInt("GiveHealth", value);
        }
    }

    public void GiveGrenade(int value2)
    {

        if (PlayerPrefs.GetInt("grenade")!= null)
        {
            Grenade = PlayerPrefs.GetInt("grenade");
            Grenade += value2;
            PlayerPrefs.SetInt("grenade", Grenade);
        }
        else
        {
            Grenade += value2;
            PlayerPrefs.SetInt("grenade", Grenade);
        }
    }

    public void WatchAddforCoin()
    {
        PlayerPrefs.SetInt("WatchaddCoin", 1);
        AdsManager.instance.ShowRewardedVideo();
    }

    public void WatchAddforHealth()
    {
        PlayerPrefs.SetInt("WatchaddHealth", 1);
        AdsManager.instance.ShowRewardedVideo();
    }

    public void WatchAddforGrendae()
    {
        GiveGrenade(1);
    }
    //public void Ads()
    //{
      //  AdsManager.instance.ShowRewardedVideo();
    //}

}
