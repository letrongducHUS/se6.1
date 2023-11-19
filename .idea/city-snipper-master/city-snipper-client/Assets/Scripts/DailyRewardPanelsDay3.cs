using UnityEngine;
using UnityEngine.UI;

public class DailyRewardPanelsDay3 : MonoBehaviour
{
    private Button ChestButton;
    public GameObject DailyBonusPopup;
    public int CoinsGive;
    public Text DailyValue;
    private int day3 = 2;
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
            day3 = -1;
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
        if (day3 == (int)System.DateTime.Now.DayOfWeek)
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