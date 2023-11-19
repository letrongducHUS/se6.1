using UnityEngine;
using System;
using UnityEngine.UI;

public class DailyRewardPanelsDay1 : MonoBehaviour
{
    private Button ChestButton;
    private ulong lastchestopen;
    public int CoinsGive;
    public GameObject DailyBonusPopup;
    public Text DailyValue;
    private int day1 = 0;
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
            day1 = -1;
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
        if (day1 == (int)System.DateTime.Now.DayOfWeek)
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