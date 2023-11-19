using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DailyRewardPanelsDay6 : MonoBehaviour
{
    private Button ChestButton;
    private ulong lastchestopen;
    public GameObject DailyBonusPopup;
    public int CoinsGive;
    public Text DailyValue;
    private int day6 = 5;
    private void Start()
    {
        ChestButton = GetComponent<Button>();
        if (PlayerPrefs.GetInt("ValueOnceSet4") == 1)
        {
            //do nothing
        }
        else
        {
            if (PlayerPrefs.GetInt("Callchestonce6") == 1)
            {

            }
            else
            {
                PlayerPrefs.SetInt("Callchestonce6", 1);
                ChestClick();
            }
        }
        lastchestopen = ulong.Parse(PlayerPrefs.GetString("LastChestOpenDay6"));
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
            day6 = -1;
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
        if (day6 == (int)System.DateTime.Now.DayOfWeek)
        {
            return true;
        }
        return false;
    }

    public void PopupOff()
    {
        DailyBonusPopup.SetActive(false);
    }
}