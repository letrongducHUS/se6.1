using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Soomla.Store;


public class MainMenuUI : MonoBehaviour
{

    // Use this for initialization
    public AudioClip BtnClickClip = null;
    AudioSource srcBtnClick;


    public GameObject MainmenuPanel;
    public GameObject ShopPanel;
    public GameObject InventoryPanel;
    public GameObject DailyRewardsPanel;


    public GameObject EliteMissionPanel;
    public GameObject EliteMissionPanel1;
    public GameObject EliteMissionPanel2;
    public GameObject RoyaleBattlePanel;


    public GameObject m24InfoPanel;
    public GameObject awmro91InfoPanel;
    public GameObject vss142InfoPanel;
    public GameObject SksInfoPanel;
    public GameObject minisniperInfoPanel;
    public GameObject awmr182InfoPanel;
    public GameObject vss199InfoPanel;
    public GameObject l96a1InfoPanel;

    public GameObject m24Buybt;
    public GameObject vss142Buybt;
    public GameObject SksBuybt;
    public GameObject minisniperBuybt;
    public GameObject awmr182Buybt;
    public GameObject vss199Buybt;
    public GameObject l96a1Buybt;

    public GameObject m24Buy;
    public GameObject vss142Buy;
    public GameObject SksBuy;
    public GameObject minisniperBuy;
    public GameObject awmr182Buy;
    public GameObject vss199Buy;
    public GameObject l96a1Buy;

    public GameObject m24Equiped;
    public GameObject vss142Equiped;
    public GameObject SksEquiped;
    public GameObject minisniperEquiped;
    public GameObject awmr182Equiped;
    public GameObject vss199Equiped;
    public GameObject l96a1Equiped;

    public GameObject customizationPanel;
    public GameObject Music;

    public Text TotalCoins;
    public Text TotalHealth;

    public GameObject GreenHole1;
    public GameObject GreenHole2;
    public GameObject GreenHole3;

    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;


    public GameObject CoinPanel;
    public GameObject HealthPanel;
    public static int numbers = 1;


    public GameObject ADSNotAvailable;
    public GameObject InternetNotConnected;
    public GameObject ThousandCoinsGets;
    public GameObject OneHealthGets;
    public GameObject OneGrenadeGets;
    public GameObject Play;
    public GameObject iInfoPanel;
    public GameObject Watch3DoBjectsCamera;
    public GameObject Canvas1;
    public GameObject Canvas2;
    public static MainMenuUI instance;
    public static bool firstLoad = false;

    void Start()
    {

        //PlayerPrefs.DeleteAll();

        instance = this;
        Cursor.lockState = CursorLockMode.None;
        srcBtnClick = gameObject.AddComponent<AudioSource>();

        Watch3DoBjectsCamera.SetActive(true);
        AudioListener.pause = false;
        Time.timeScale = 1;


        if (PlayerPrefs.GetInt("DailyBonusMultiplePanel") == 1)
        {
            MainmenuPanel.SetActive(false);
            DailyRewardsPanel.SetActive(true);
        }
        else
        {
            MainmenuPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("EliteMissionPanel") == 1)
        {
            EliteMissionPan();
            PlayerPrefs.SetInt("EliteMissionPanel", 0);
        }

        if (PlayerPrefs.GetInt("EliteMissionPanel1") == 1)
        {
            EliteMissionPan1();
            PlayerPrefs.SetInt("EliteMissionPanel1", 0);
        }

        if (PlayerPrefs.GetInt("EliteMissionPanel2") == 1)
        {
            EliteMissionPan2();
            PlayerPrefs.SetInt("EliteMissionPanel2", 0);
        }

        if (PlayerPrefs.GetInt("RoyaleBattlePanel") == 1)
        {
            RoyaleBattlePan();
            PlayerPrefs.SetInt("RoyaleBattlePanel", 0);
        }

        if (PlayerPrefs.GetInt("CombatFieldPanel") == 1)
        {
            CombatFieldPan();
            PlayerPrefs.SetInt("CombatFieldPanel", 0);
        }

        //		SabloSdk.Instance.LogScreen("Main Menu");
        //
        //		SabloSdk.Instance.ShowBanner ();
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("m24") == 1)
        {
            m24Buybt.SetActive(false);
            m24Buy.SetActive(false);
            m24Equiped.SetActive(true);
        }

        if (PlayerPrefs.GetInt("vss142") == 1)
        {
            vss142Buybt.SetActive(false);
            vss142Buy.SetActive(false);
            vss142Equiped.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Sks") == 1)
        {
            SksBuybt.SetActive(false);
            SksBuy.SetActive(false);
            SksEquiped.SetActive(true);
        }


        if (PlayerPrefs.GetInt("minisniper") == 1)
        {
            minisniperBuybt.SetActive(false);
            minisniperBuy.SetActive(false);
            minisniperEquiped.SetActive(true);
        }

        if (PlayerPrefs.GetInt("awmr182") == 1)
        {
            awmr182Buybt.SetActive(false);
            awmr182Buy.SetActive(false);
            awmr182Equiped.SetActive(true);
        }
        if (PlayerPrefs.GetInt("vss199") == 1)
        {
            vss199Buybt.SetActive(false);
            vss199Buy.SetActive(false);
            vss199Equiped.SetActive(true);
        }
        if (PlayerPrefs.GetInt("l96a1") == 1)
        {
            l96a1Buybt.SetActive(false);
            l96a1Buy.SetActive(false);
            l96a1Equiped.SetActive(true);
        }

        TotalCoins.text = PlayerPrefs.GetInt("score").ToString();
        TotalHealth.text = PlayerPrefs.GetInt("GiveHealth").ToString();

    }

    public void BacktoMainMenuPan()
    {
        //        if (!DailyRewardsPanel.activeInHierarchy == true) 
        //        {
        //            AdsManager.instance.ShowInterstitial();
        //        }

        MainmenuPanel.SetActive(true);
        Watch3DoBjectsCamera.SetActive(true);
        EliteMissionPanel.SetActive(false);
        EliteMissionPanel1.SetActive(false);
        EliteMissionPanel2.SetActive(false);
        RoyaleBattlePanel.SetActive(false);
        Play.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);

        DailyRewardsPanel.SetActive(false);
    }

    public void ShopBacktoMainMenuPan()
    {
        Watch3DoBjectsCamera.SetActive(true);
        ShopPanel.SetActive(false);
    }

    public void ShopPan()
    {
        Watch3DoBjectsCamera.SetActive(false);
        ShopPanel.SetActive(true);
        InventoryPanel.SetActive(false);

    }

    public void CoinPan()
    {
        ShopPanel.SetActive(true);
        Watch3DoBjectsCamera.SetActive(false);
        CoinPanel.SetActive(true);
        HealthPanel.SetActive(false);
    }


    public void HealthPan()
    {
        ShopPanel.SetActive(true);
        Watch3DoBjectsCamera.SetActive(false);
        CoinPanel.SetActive(false);
        HealthPanel.SetActive(true);
    }

    public void InventoryPan()
    {
        MainmenuPanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(true);

    }

    public void SelectTeamPan()
    {
        MainmenuPanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);

    }

    public void DailyBonusPan()
    {
        // AdsManager.instance.ShowInterstitial();   this is advertisement
        // MainmenuPanel.SetActive(false);
        ShopPanel.SetActive(false);
        InventoryPanel.SetActive(false);
        DailyRewardsPanel.SetActive(true);
    }
    public void BacktoMissionsPan()
    {
        Watch3DoBjectsCamera.SetActive(false);

        Play.SetActive(false);
        EliteMissionPanel.SetActive(false);
        EliteMissionPanel1.SetActive(false);
        EliteMissionPanel2.SetActive(false);
        RoyaleBattlePanel.SetActive(false);

    }
    public void MissionsPan()
    {
        Watch3DoBjectsCamera.SetActive(false);
        Play.SetActive(false);

    }
    public void EliteMissionPan()
    {
        MainmenuPanel.SetActive(false);
        Play.SetActive(false);
        EliteMissionPanel.SetActive(true);
        EliteMissionPanel1.SetActive(false);
        EliteMissionPanel2.SetActive(false);
        RoyaleBattlePanel.SetActive(false);

    }

    public void EliteMissionPan1()
    {
        Play.SetActive(false);
        EliteMissionPanel.SetActive(false);
        EliteMissionPanel1.SetActive(true);
        EliteMissionPanel2.SetActive(false);
        RoyaleBattlePanel.SetActive(false);

    }

    public void EliteMissionPan2()
    {
        EliteMissionPanel.SetActive(false);
        Play.SetActive(false);
        EliteMissionPanel1.SetActive(false);
        EliteMissionPanel2.SetActive(true);
        RoyaleBattlePanel.SetActive(false);

    }

    public void RoyaleBattlePan()
    {
        MainmenuPanel.SetActive(false);
        Play.SetActive(false);
        EliteMissionPanel.SetActive(false);
        EliteMissionPanel1.SetActive(false);
        EliteMissionPanel2.SetActive(false);
        RoyaleBattlePanel.SetActive(true);

    }

    public void CombatFieldPan()
    {
        MainmenuPanel.SetActive(false);
        Play.SetActive(false);
        EliteMissionPanel.SetActive(false);
        EliteMissionPanel1.SetActive(false);
        EliteMissionPanel2.SetActive(false);
        RoyaleBattlePanel.SetActive(false);

    }

    public void M24Pan()
    {

        m24InfoPanel.SetActive(true);
        awmro91InfoPanel.SetActive(false);
        vss142InfoPanel.SetActive(false);
        SksInfoPanel.SetActive(false);
        minisniperInfoPanel.SetActive(false);
        awmr182InfoPanel.SetActive(false);
        vss199InfoPanel.SetActive(false);
        l96a1InfoPanel.SetActive(false);
    }

    public void Awmro91Pan()
    {

        m24InfoPanel.SetActive(false);
        awmro91InfoPanel.SetActive(true);
        vss142InfoPanel.SetActive(false);
        SksInfoPanel.SetActive(false);
        minisniperInfoPanel.SetActive(false);
        awmr182InfoPanel.SetActive(false);
        vss199InfoPanel.SetActive(false);
        l96a1InfoPanel.SetActive(false);
    }

    public void Vss142Pan()
    {
        m24InfoPanel.SetActive(false);
        awmro91InfoPanel.SetActive(false);
        vss142InfoPanel.SetActive(true);
        SksInfoPanel.SetActive(false);
        minisniperInfoPanel.SetActive(false);
        awmr182InfoPanel.SetActive(false);
        vss199InfoPanel.SetActive(false);
        l96a1InfoPanel.SetActive(false);
    }

    public void SksPan()
    {
        m24InfoPanel.SetActive(false);
        awmro91InfoPanel.SetActive(false);
        vss142InfoPanel.SetActive(false);
        SksInfoPanel.SetActive(true);
        minisniperInfoPanel.SetActive(false);
        awmr182InfoPanel.SetActive(false);
        vss199InfoPanel.SetActive(false);
        l96a1InfoPanel.SetActive(false);
    }

    public void MinisniperPan()
    {
        m24InfoPanel.SetActive(false);
        awmro91InfoPanel.SetActive(false);
        vss142InfoPanel.SetActive(false);
        SksInfoPanel.SetActive(false);
        minisniperInfoPanel.SetActive(true);
        awmr182InfoPanel.SetActive(false);
        vss199InfoPanel.SetActive(false);
        l96a1InfoPanel.SetActive(false);
    }

    public void Awmr182Pan()
    {
        m24InfoPanel.SetActive(false);
        awmro91InfoPanel.SetActive(false);
        vss142InfoPanel.SetActive(false);
        SksInfoPanel.SetActive(false);
        minisniperInfoPanel.SetActive(false);
        awmr182InfoPanel.SetActive(true);
        vss199InfoPanel.SetActive(false);
        l96a1InfoPanel.SetActive(false);
    }

    public void Vss199Pan()
    {
        m24InfoPanel.SetActive(false);
        awmro91InfoPanel.SetActive(false);
        vss142InfoPanel.SetActive(false);
        SksInfoPanel.SetActive(false);
        minisniperInfoPanel.SetActive(false);
        awmr182InfoPanel.SetActive(false);
        vss199InfoPanel.SetActive(true);
        l96a1InfoPanel.SetActive(false);
    }

    public void l96a1Pan()
    {
        m24InfoPanel.SetActive(false);
        awmro91InfoPanel.SetActive(false);
        vss142InfoPanel.SetActive(false);
        SksInfoPanel.SetActive(false);
        minisniperInfoPanel.SetActive(false);
        awmr182InfoPanel.SetActive(false);
        vss199InfoPanel.SetActive(false);
        l96a1InfoPanel.SetActive(true);
    }

    public void SettingOn()
    {

        PlaySound();
        Canvas2.SetActive(true);
        Canvas1.SetActive(false);
        //Watch3DoBjectsCamera.SetActive(false);
        //customizationPanel.SetActive(true);
    }

    public void SetingBack()
    {
        PlaySound();
        AdsManager.instance.ShowInterstitial();
        Watch3DoBjectsCamera.SetActive(true);
        customizationPanel.SetActive(false);
    }


    public void ForwareCharacterCheck(int value)
    {
        numbers += value;
        if (numbers >= 3)
        {
            numbers = 3;
        }

        if (numbers == 1)
        {
            Character1.SetActive(true);
            GreenHole1.SetActive(true);
            Character2.SetActive(false);
            GreenHole2.SetActive(false);
            Character3.SetActive(false);
            GreenHole3.SetActive(false);
        }

        if (numbers == 2)
        {

            Character1.SetActive(false);
            GreenHole1.SetActive(false);
            Character2.SetActive(true);
            GreenHole2.SetActive(true);
            Character3.SetActive(false);
            GreenHole3.SetActive(false);
        }
        if (numbers == 3)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);
            Character2.SetActive(false);
            GreenHole2.SetActive(false);
            Character3.SetActive(true);
            GreenHole3.SetActive(true);
        }



    }

    public void BackwardCharacterCheck(int value)
    {
        numbers -= value;
        Debug.Log(numbers);
        if (numbers <= 1)
        {
            numbers = 1;
        }



        if (numbers == 1)
        {
            Character1.SetActive(true);
            GreenHole1.SetActive(true);
            Character2.SetActive(false);
            GreenHole2.SetActive(false);
            Character3.SetActive(false);
            GreenHole3.SetActive(false);
        }

        if (numbers == 2)
        {
            Character1.SetActive(false);
            GreenHole1.SetActive(false);
            Character2.SetActive(true);
            GreenHole2.SetActive(true);
            Character3.SetActive(false);
            GreenHole3.SetActive(false);
        }
        if (numbers == 3)
        {

            Character1.SetActive(false);
            GreenHole1.SetActive(false);
            Character2.SetActive(false);
            GreenHole2.SetActive(false);
            Character3.SetActive(true);
            GreenHole3.SetActive(true);
        }

    }
    public void iInfoPanOn()
    {
        Watch3DoBjectsCamera.SetActive(false);
        iInfoPanel.SetActive(true);
    }
    public void iInfoPanOff()
    {
        Watch3DoBjectsCamera.SetActive(true);
        iInfoPanel.SetActive(false);
    }
    public void adnotavailable()
    {
        Watch3DoBjectsCamera.SetActive(false);
        ADSNotAvailable.SetActive(true);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);

    }

    public void Thousndcoin()
    {
        Watch3DoBjectsCamera.SetActive(false);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(true);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);

    }

    public void OneHEALTH()
    {
        Watch3DoBjectsCamera.SetActive(false);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(true);
        OneGrenadeGets.SetActive(false);

    }

    public void OneGrenade()
    {
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(true);

    }

    public void InternetnotAVAIL()
    {
        Watch3DoBjectsCamera.SetActive(false);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(true);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);
        Watch3DoBjectsCamera.SetActive(false);

    }

    public void backOffromPanel()
    {
        Watch3DoBjectsCamera.SetActive(true);
        ADSNotAvailable.SetActive(false);
        InternetNotConnected.SetActive(false);
        ThousandCoinsGets.SetActive(false);
        OneHealthGets.SetActive(false);
        OneGrenadeGets.SetActive(false);

    }
    public void btn_Play()
    {
        PlaySound();
        Application.LoadLevel("LevelSelection");
    }
    public void btn_RemoveAds()
    {
        PlaySound();
        //StoreInventory.BuyItem(GameObject.FindObjectOfType<SoomlaFoo>().purchaseIDs[0]);
    }
    //public void btn_rate_Now()
    //{
     //   PlaySound();
    //    Application.OpenURL("");
//

   // }
    public void PlaySound()
    {
        srcBtnClick.clip = BtnClickClip;
        srcBtnClick.Play();

    }
}