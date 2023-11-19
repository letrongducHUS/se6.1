using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DailyRewardPanelsDay5 : MonoBehaviour
{
    private Button ChestButton;
    private ulong lastchestopen;
    public GameObject DailyBonusPopup;
    public int CoinsGive;
    public Text DailyValue;
    private int day5 = 4;
    private void Start()
    {
        ChestButton = GetComponent<Button>();
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
            day5 = -1;
            ChestButton.interactable = false;
            DailyBonusPopup.SetActive(true);
            DailyValue.text = "You Got " + CoinsGive + " Coins";
            DeductionMoney.instance.GiveCoin(CoinsGive);
        }
        else
        {
            //do nothing
        }
        // DeductionMoney.instance.GiveCoin(2000);
    }

    private bool isChestReady()
    {
        if (day5 == (int)System.DateTime.Now.DayOfWeek)
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