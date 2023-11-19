using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DailyRewardPanelsDay7 : MonoBehaviour
{
    public float MsToWait = 5000.0f;
    public Text ChestTimer;
    private Button ChestButton;
    private ulong lastchestopen;
    public GameObject DailyBonusPopup;
    public int CoinsGive;
    public Text DailyValue;
    private int day7 = 6;

    private void Start()
    {
        ChestButton = GetComponent<Button>();
        if (PlayerPrefs.GetInt("ValueOnceSet5") == 1)
        {
            //do nothing
        }
        else
        {
            if (PlayerPrefs.GetInt("Callchestonce7") == 1)
            {

            }
            else
            {
                PlayerPrefs.SetInt("Callchestonce7", 1);
                ChestClick();
            }
        }
        lastchestopen = ulong.Parse(PlayerPrefs.GetString("LastChestOpenDay7"));
        if (!isChestReady())
        {
            ChestButton.interactable = false;
        }

    }

    private void Update()
    {
        if (!ChestButton.IsInteractable())
        {
            if (isChestReady())
            {
                ChestButton.interactable = true;
                return;
            }
        }
    }

    public void ChestClick()
    {
        if (isChestReady())
        {
            day7 = -1;
            ChestButton.interactable = false;
            DailyBonusPopup.SetActive(true);
            DailyValue.text = "You Got " + CoinsGive + " Coins";
            DeductionMoney.instance.GiveCoin(CoinsGive);
        }
        else
        {
            //do nothing
        }
    }

    private bool isChestReady()
    {
        if (day7 == (int)System.DateTime.Now.DayOfWeek)
        {
            PlayerPrefs.SetInt("ValueOnceSet4", 1);
            return true;
        }
        return false;
    }

    public void PopupOff()
    {
        DailyBonusPopup.SetActive(false);
    }
}