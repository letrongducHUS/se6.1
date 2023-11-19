using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class DailyReward : MonoBehaviour
{
    public float MsToWait = 5000.0f;
    public Text ChestTimer;
    private Button ChestButton;
    private ulong lastchestopen;

    private void Start()
    {
        ChestButton = GetComponent<Button>();
        
        lastchestopen=  ulong.Parse(PlayerPrefs.GetString("LastChestOpen"));
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


            //Set Timer
            ulong diff = ((ulong)DateTime.Now.Ticks - lastchestopen);

            ulong m = diff / TimeSpan.TicksPerMillisecond;

            float SecondLeft = (float)(MsToWait - m) / 1000;

            string r = "";

            // Hours
            r += ((int)SecondLeft / 3600).ToString() + "h ";
            SecondLeft -= ((int)SecondLeft / 3600) * 3600;
            // Minutes
            r += ((int)SecondLeft / 60).ToString("00") + "m ";
            //seconds
            r += (SecondLeft % 60).ToString("00") + "s";

            ChestTimer.text = r;
        }
    }

    public void ChestClick()
    {
        lastchestopen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("LastChestOpen", lastchestopen.ToString());
        ChestButton.interactable = false;
        DeductionMoney.instance.GiveCoin(2000);
        MainMenuUI.instance.BacktoMainMenuPan();
    }

    private bool isChestReady()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastchestopen);

        ulong m = diff / TimeSpan.TicksPerMillisecond;

        float SecondLeft = (float)(MsToWait - m) / 1000;
        Debug.Log(SecondLeft);
        if (SecondLeft < 0)
        {
            ChestTimer.text = "Ready!";
            return true;
        }
              

        return false;   
    }
}
