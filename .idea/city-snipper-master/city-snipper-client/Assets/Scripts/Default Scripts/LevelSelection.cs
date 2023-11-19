using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{

    public AudioClip BtnClickClip = null;
    AudioSource srcBtnClick;


    public Button[] levels;
    public Sprite lockSprite;
    [Header("Multiple lock sprites")]
    public bool multipleLocks = false;
    public Sprite[] multipleLockSprite;
    public GameObject startmission;
    public int mylevelselect;
    // Use this for initialization
    void Start()
    {
        srcBtnClick = gameObject.AddComponent<AudioSource>();
        Time.timeScale = 1;

        for (int i = 0; i < levels.Length; i++)
        {
            if (i <= Preferences.Instance.LevelUnlock - 1)
            {
                levels[i].enabled = true;
                levels[i].transform.Find("lock").gameObject.SetActive(false);
            }
            else
            {
                levels[i].enabled = false;
                if (multipleLocks)
                {
                    levels[i].transform.Find("lock").GetComponent<Image>().sprite = multipleLockSprite[i];

                    if (multipleLockSprite[8])
                    {
                        levels[8].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                    }

                    if (Preferences.Instance.Level == 10)
                    {
                        levels[9].enabled = true;
                        levels[9].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                        levels[8].transform.Find("lock").gameObject.SetActive(false);

                    }

                    if (Preferences.Instance.Level == 11)
                    {
                        levels[10].enabled = true;
                        levels[10].transform.Find("lock").gameObject.SetActive(false);
                        levels[9].enabled = true;
                        levels[9].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                        levels[8].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 12)
                    {
                        levels[11].enabled = true;
                        levels[11].transform.Find("lock").gameObject.SetActive(false);
                        levels[10].enabled = true;
                        levels[10].transform.Find("lock").gameObject.SetActive(false);
                        levels[9].enabled = true;
                        levels[9].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                        levels[8].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 13)
                    {
                        levels[12].enabled = true;
                        levels[12].transform.Find("lock").gameObject.SetActive(false);
                        levels[11].enabled = true;
                        levels[11].transform.Find("lock").gameObject.SetActive(false);
                        levels[10].enabled = true;
                        levels[10].transform.Find("lock").gameObject.SetActive(false);
                        levels[9].enabled = true;
                        levels[9].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                        levels[8].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 14)
                    {
                        levels[13].enabled = true;
                        levels[13].transform.Find("lock").gameObject.SetActive(false);
                        levels[12].enabled = true;
                        levels[12].transform.Find("lock").gameObject.SetActive(false);
                        levels[11].enabled = true;
                        levels[11].transform.Find("lock").gameObject.SetActive(false);
                        levels[10].enabled = true;
                        levels[10].transform.Find("lock").gameObject.SetActive(false);
                        levels[9].enabled = true;
                        levels[9].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                        levels[8].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 15)
                    {
                        levels[14].enabled = true;
                        levels[14].transform.Find("lock").gameObject.SetActive(false);
                        levels[13].enabled = true;
                        levels[13].transform.Find("lock").gameObject.SetActive(false);
                        levels[12].enabled = true;
                        levels[12].transform.Find("lock").gameObject.SetActive(false);
                        levels[11].enabled = true;
                        levels[11].transform.Find("lock").gameObject.SetActive(false);
                        levels[10].enabled = true;
                        levels[10].transform.Find("lock").gameObject.SetActive(false);
                        levels[9].enabled = true;
                        levels[9].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                        levels[8].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 16)
                    {
                        levels[15].enabled = true;
                        levels[15].transform.Find("lock").gameObject.SetActive(false);
                        levels[14].enabled = true;
                        levels[14].transform.Find("lock").gameObject.SetActive(false);
                        levels[13].enabled = true;
                        levels[13].transform.Find("lock").gameObject.SetActive(false);
                        levels[12].enabled = true;
                        levels[12].transform.Find("lock").gameObject.SetActive(false);
                        levels[11].enabled = true;
                        levels[11].transform.Find("lock").gameObject.SetActive(false);
                        levels[10].enabled = true;
                        levels[10].transform.Find("lock").gameObject.SetActive(false);
                        levels[9].enabled = true;
                        levels[9].transform.Find("lock").gameObject.SetActive(false);
                        levels[8].enabled = true;
                        levels[8].transform.Find("lock").gameObject.SetActive(false);
                    }


                    if (multipleLockSprite[16])
                    {
                        levels[16].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                    }

                    if (Preferences.Instance.Level == 18)
                    {
                        levels[17].enabled = true;
                        levels[17].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                        levels[16].transform.Find("lock").gameObject.SetActive(false);

                    }

                    if (Preferences.Instance.Level == 19)
                    {
                        levels[18].enabled = true;
                        levels[18].transform.Find("lock").gameObject.SetActive(false);
                        levels[17].enabled = true;
                        levels[17].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                        levels[16].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 20)
                    {
                        levels[19].enabled = true;
                        levels[19].transform.Find("lock").gameObject.SetActive(false);
                        levels[18].enabled = true;
                        levels[18].transform.Find("lock").gameObject.SetActive(false);
                        levels[17].enabled = true;
                        levels[17].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                        levels[16].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 21)
                    {
                        levels[20].enabled = true;
                        levels[20].transform.Find("lock").gameObject.SetActive(false);
                        levels[19].enabled = true;
                        levels[19].transform.Find("lock").gameObject.SetActive(false);
                        levels[18].enabled = true;
                        levels[18].transform.Find("lock").gameObject.SetActive(false);
                        levels[17].enabled = true;
                        levels[17].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                        levels[16].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 22)
                    {
                        levels[21].enabled = true;
                        levels[21].transform.Find("lock").gameObject.SetActive(false);
                        levels[20].enabled = true;
                        levels[20].transform.Find("lock").gameObject.SetActive(false);
                        levels[19].enabled = true;
                        levels[19].transform.Find("lock").gameObject.SetActive(false);
                        levels[18].enabled = true;
                        levels[18].transform.Find("lock").gameObject.SetActive(false);
                        levels[17].enabled = true;
                        levels[17].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                        levels[16].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 23)
                    {
                        levels[22].enabled = true;
                        levels[22].transform.Find("lock").gameObject.SetActive(false);
                        levels[21].enabled = true;
                        levels[21].transform.Find("lock").gameObject.SetActive(false);
                        levels[20].enabled = true;
                        levels[20].transform.Find("lock").gameObject.SetActive(false);
                        levels[19].enabled = true;
                        levels[19].transform.Find("lock").gameObject.SetActive(false);
                        levels[17].enabled = true;
                        levels[17].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                        levels[16].transform.Find("lock").gameObject.SetActive(false);
                    }
                    if (Preferences.Instance.Level == 24)
                    {
                        levels[23].enabled = true;
                        levels[23].transform.Find("lock").gameObject.SetActive(false);
                        levels[22].enabled = true;
                        levels[22].transform.Find("lock").gameObject.SetActive(false);
                        levels[21].enabled = true;
                        levels[21].transform.Find("lock").gameObject.SetActive(false);
                        levels[20].enabled = true;
                        levels[20].transform.Find("lock").gameObject.SetActive(false);
                        levels[19].enabled = true;
                        levels[19].transform.Find("lock").gameObject.SetActive(false);
                        levels[18].enabled = true;
                        levels[18].transform.Find("lock").gameObject.SetActive(false);
                        levels[17].enabled = true;
                        levels[17].transform.Find("lock").gameObject.SetActive(false);
                        levels[16].enabled = true;
                        levels[16].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (multipleLockSprite[24])
                    {
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                    }


                    if (Preferences.Instance.Level == 26)
                    {
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (Preferences.Instance.Level == 27)
                    {
                        levels[26].enabled = true;
                        levels[26].transform.Find("lock").gameObject.SetActive(false);
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (Preferences.Instance.Level == 28)
                    {
                        levels[27].enabled = true;
                        levels[27].transform.Find("lock").gameObject.SetActive(false);
                        levels[26].enabled = true;
                        levels[26].transform.Find("lock").gameObject.SetActive(false);
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (Preferences.Instance.Level == 29)
                    {
                        levels[28].enabled = true;
                        levels[28].transform.Find("lock").gameObject.SetActive(false);
                        levels[27].enabled = true;
                        levels[27].transform.Find("lock").gameObject.SetActive(false);
                        levels[26].enabled = true;
                        levels[26].transform.Find("lock").gameObject.SetActive(false);
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (Preferences.Instance.Level == 29)
                    {
                        levels[28].enabled = true;
                        levels[28].transform.Find("lock").gameObject.SetActive(false);
                        levels[27].enabled = true;
                        levels[27].transform.Find("lock").gameObject.SetActive(false);
                        levels[26].enabled = true;
                        levels[26].transform.Find("lock").gameObject.SetActive(false);
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (Preferences.Instance.Level == 30)
                    {
                        levels[29].enabled = true;
                        levels[29].transform.Find("lock").gameObject.SetActive(false);
                        levels[28].enabled = true;
                        levels[28].transform.Find("lock").gameObject.SetActive(false);
                        levels[27].enabled = true;
                        levels[27].transform.Find("lock").gameObject.SetActive(false);
                        levels[26].enabled = true;
                        levels[26].transform.Find("lock").gameObject.SetActive(false);
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (Preferences.Instance.Level == 31)
                    {
                        levels[30].enabled = true;
                        levels[30].transform.Find("lock").gameObject.SetActive(false);
                        levels[29].enabled = true;
                        levels[29].transform.Find("lock").gameObject.SetActive(false);
                        levels[28].enabled = true;
                        levels[28].transform.Find("lock").gameObject.SetActive(false);
                        levels[27].enabled = true;
                        levels[27].transform.Find("lock").gameObject.SetActive(false);
                        levels[26].enabled = true;
                        levels[26].transform.Find("lock").gameObject.SetActive(false);
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                    if (Preferences.Instance.Level == 32)
                    {
                        levels[31].enabled = true;
                        levels[31].transform.Find("lock").gameObject.SetActive(false);
                        levels[30].enabled = true;
                        levels[30].transform.Find("lock").gameObject.SetActive(false);
                        levels[29].enabled = true;
                        levels[29].transform.Find("lock").gameObject.SetActive(false);
                        levels[28].enabled = true;
                        levels[28].transform.Find("lock").gameObject.SetActive(false);
                        levels[27].enabled = true;
                        levels[27].transform.Find("lock").gameObject.SetActive(false);
                        levels[26].enabled = true;
                        levels[26].transform.Find("lock").gameObject.SetActive(false);
                        levels[25].enabled = true;
                        levels[25].transform.Find("lock").gameObject.SetActive(false);
                        levels[24].enabled = true;
                        levels[24].transform.Find("lock").gameObject.SetActive(false);
                    }

                }

                else
                {
                    levels[i].transform.Find("lock").GetComponent<Image>().sprite = lockSprite;
                }

            }
        }


        if (PlayerPrefs.GetInt("level10") == 1)
        {
            levels[9].enabled = true;
            levels[9].transform.Find("lock").gameObject.SetActive(false);
            levels[8].enabled = true;
            levels[8].transform.Find("lock").gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level11") == 1)
        {
            levels[10].enabled = true;
            levels[10].transform.Find("lock").gameObject.SetActive(false);
            levels[9].enabled = true;
            levels[9].transform.Find("lock").gameObject.SetActive(false);
            levels[8].enabled = true;
            levels[8].transform.Find("lock").gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level12") == 1)
        {
            levels[11].enabled = true;
            levels[11].transform.Find("lock").gameObject.SetActive(false);
            levels[10].enabled = true;
            levels[10].transform.Find("lock").gameObject.SetActive(false);
            levels[9].enabled = true;
            levels[9].transform.Find("lock").gameObject.SetActive(false);
            levels[8].enabled = true;
            levels[8].transform.Find("lock").gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level13") == 1)
        {
            levels[12].enabled = true;
            levels[12].transform.Find("lock").gameObject.SetActive(false);
            levels[11].enabled = true;
            levels[11].transform.Find("lock").gameObject.SetActive(false);
            levels[10].enabled = true;
            levels[10].transform.Find("lock").gameObject.SetActive(false);
            levels[9].enabled = true;
            levels[9].transform.Find("lock").gameObject.SetActive(false);
            levels[8].enabled = true;
            levels[8].transform.Find("lock").gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level14") == 1)
        {
            levels[13].enabled = true;
            levels[13].transform.Find("lock").gameObject.SetActive(false);
            levels[12].enabled = true;
            levels[12].transform.Find("lock").gameObject.SetActive(false);
            levels[11].enabled = true;
            levels[11].transform.Find("lock").gameObject.SetActive(false);
            levels[10].enabled = true;
            levels[10].transform.Find("lock").gameObject.SetActive(false);
            levels[9].enabled = true;
            levels[9].transform.Find("lock").gameObject.SetActive(false);
            levels[8].enabled = true;
            levels[8].transform.Find("lock").gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level15") == 1)
        {
            levels[14].enabled = true;
            levels[14].transform.Find("lock").gameObject.SetActive(false);
            levels[13].enabled = true;
            levels[13].transform.Find("lock").gameObject.SetActive(false);
            levels[12].enabled = true;
            levels[12].transform.Find("lock").gameObject.SetActive(false);
            levels[11].enabled = true;
            levels[11].transform.Find("lock").gameObject.SetActive(false);
            levels[10].enabled = true;
            levels[10].transform.Find("lock").gameObject.SetActive(false);
            levels[9].enabled = true;
            levels[9].transform.Find("lock").gameObject.SetActive(false);
            levels[8].enabled = true;
            levels[8].transform.Find("lock").gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("level16") == 1)
        {
            levels[15].enabled = true;
            levels[15].transform.Find("lock").gameObject.SetActive(false);
            levels[14].enabled = true;
            levels[14].transform.Find("lock").gameObject.SetActive(false);
            levels[13].enabled = true;
            levels[13].transform.Find("lock").gameObject.SetActive(false);
            levels[12].enabled = true;
            levels[12].transform.Find("lock").gameObject.SetActive(false);
            levels[11].enabled = true;
            levels[11].transform.Find("lock").gameObject.SetActive(false);
            levels[10].enabled = true;
            levels[10].transform.Find("lock").gameObject.SetActive(false);
            levels[9].enabled = true;
            levels[9].transform.Find("lock").gameObject.SetActive(false);
            levels[8].enabled = true;
            levels[8].transform.Find("lock").gameObject.SetActive(false);

        }

        if (PlayerPrefs.GetInt("level18") == 1)
        {
            levels[17].enabled = true;
            levels[17].transform.Find("lock").gameObject.SetActive(false);
            levels[16].enabled = true;
            levels[16].transform.Find("lock").gameObject.SetActive(false);

        }

        if (PlayerPrefs.GetInt("level19") == 1)
        {
            levels[18].enabled = true;
            levels[18].transform.Find("lock").gameObject.SetActive(false);
            levels[17].enabled = true;
            levels[17].transform.Find("lock").gameObject.SetActive(false);
            levels[16].enabled = true;
            levels[16].transform.Find("lock").gameObject.SetActive(false);


        }

        if (PlayerPrefs.GetInt("level20") == 1)
        {
            levels[19].enabled = true;
            levels[19].transform.Find("lock").gameObject.SetActive(false);
            levels[18].enabled = true;
            levels[18].transform.Find("lock").gameObject.SetActive(false);
            levels[17].enabled = true;
            levels[17].transform.Find("lock").gameObject.SetActive(false);
            levels[16].enabled = true;
            levels[16].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level21") == 1)
        {
            levels[20].enabled = true;
            levels[20].transform.Find("lock").gameObject.SetActive(false);
            levels[19].enabled = true;
            levels[19].transform.Find("lock").gameObject.SetActive(false);
            levels[18].enabled = true;
            levels[18].transform.Find("lock").gameObject.SetActive(false);
            levels[17].enabled = true;
            levels[17].transform.Find("lock").gameObject.SetActive(false);
            levels[16].enabled = true;
            levels[16].transform.Find("lock").gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level22") == 1)
        {
            levels[21].enabled = true;
            levels[21].transform.Find("lock").gameObject.SetActive(false);
            levels[20].enabled = true;
            levels[20].transform.Find("lock").gameObject.SetActive(false);
            levels[19].enabled = true;
            levels[19].transform.Find("lock").gameObject.SetActive(false);
            levels[18].enabled = true;
            levels[18].transform.Find("lock").gameObject.SetActive(false);
            levels[17].enabled = true;
            levels[17].transform.Find("lock").gameObject.SetActive(false);
            levels[16].enabled = true;
            levels[16].transform.Find("lock").gameObject.SetActive(false);

        }

        if (PlayerPrefs.GetInt("level23") == 1)
        {
            levels[22].enabled = true;
            levels[22].transform.Find("lock").gameObject.SetActive(false);
            levels[21].enabled = true;
            levels[21].transform.Find("lock").gameObject.SetActive(false);
            levels[20].enabled = true;
            levels[20].transform.Find("lock").gameObject.SetActive(false);
            levels[19].enabled = true;
            levels[19].transform.Find("lock").gameObject.SetActive(false);
            levels[18].enabled = true;
            levels[18].transform.Find("lock").gameObject.SetActive(false);
            levels[17].enabled = true;
            levels[17].transform.Find("lock").gameObject.SetActive(false);
            levels[16].enabled = true;
            levels[16].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level24") == 1)
        {
            levels[23].enabled = true;
            levels[23].transform.Find("lock").gameObject.SetActive(false);
            levels[22].enabled = true;
            levels[22].transform.Find("lock").gameObject.SetActive(false);
            levels[21].enabled = true;
            levels[21].transform.Find("lock").gameObject.SetActive(false);
            levels[20].enabled = true;
            levels[20].transform.Find("lock").gameObject.SetActive(false);
            levels[19].enabled = true;
            levels[19].transform.Find("lock").gameObject.SetActive(false);
            levels[18].enabled = true;
            levels[18].transform.Find("lock").gameObject.SetActive(false);
            levels[17].enabled = true;
            levels[17].transform.Find("lock").gameObject.SetActive(false);
            levels[16].enabled = true;
            levels[16].transform.Find("lock").gameObject.SetActive(false);

        }

        if (PlayerPrefs.GetInt("level26") == 1)
        {
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);

        }

        if (PlayerPrefs.GetInt("level27") == 1)
        {
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);

        }

        if (PlayerPrefs.GetInt("level28") == 1)
        {
            levels[27].enabled = true;
            levels[27].transform.Find("lock").gameObject.SetActive(false);
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);

        }

        if (PlayerPrefs.GetInt("level29") == 1)
        {
            levels[28].enabled = true;
            levels[28].transform.Find("lock").gameObject.SetActive(false);
            levels[27].enabled = true;
            levels[27].transform.Find("lock").gameObject.SetActive(false);
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level30") == 1)
        {
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[28].enabled = true;
            levels[28].transform.Find("lock").gameObject.SetActive(false);
            levels[27].enabled = true;
            levels[27].transform.Find("lock").gameObject.SetActive(false);
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level31") == 1)
        {
            levels[30].enabled = true;
            levels[30].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[28].enabled = true;
            levels[28].transform.Find("lock").gameObject.SetActive(false);
            levels[27].enabled = true;
            levels[27].transform.Find("lock").gameObject.SetActive(false);
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level32") == 1)
        {
            levels[31].enabled = true;
            levels[31].transform.Find("lock").gameObject.SetActive(false);
            levels[30].enabled = true;
            levels[30].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[28].enabled = true;
            levels[28].transform.Find("lock").gameObject.SetActive(false);
            levels[27].enabled = true;
            levels[27].transform.Find("lock").gameObject.SetActive(false);
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level32") == 1)
        {
            levels[31].enabled = true;
            levels[31].transform.Find("lock").gameObject.SetActive(false);
            levels[30].enabled = true;
            levels[30].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[28].enabled = true;
            levels[28].transform.Find("lock").gameObject.SetActive(false);
            levels[27].enabled = true;
            levels[27].transform.Find("lock").gameObject.SetActive(false);
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level33") == 1)
        {
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
            levels[31].enabled = true;
            levels[31].transform.Find("lock").gameObject.SetActive(false);
            levels[30].enabled = true;
            levels[30].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[29].enabled = true;
            levels[29].transform.Find("lock").gameObject.SetActive(false);
            levels[28].enabled = true;
            levels[28].transform.Find("lock").gameObject.SetActive(false);
            levels[27].enabled = true;
            levels[27].transform.Find("lock").gameObject.SetActive(false);
            levels[26].enabled = true;
            levels[26].transform.Find("lock").gameObject.SetActive(false);
            levels[25].enabled = true;
            levels[25].transform.Find("lock").gameObject.SetActive(false);
            levels[24].enabled = true;
            levels[24].transform.Find("lock").gameObject.SetActive(false);
        }

        /*if (PlayerPrefs.GetInt("level34") == 1)
        {
            levels[33].enabled = true;
            levels[33].transform.Find("lock").gameObject.SetActive(false);
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level35") == 1)
        {
            levels[34].enabled = true;
            levels[34].transform.Find("lock").gameObject.SetActive(false);
            levels[33].enabled = true;
            levels[33].transform.Find("lock").gameObject.SetActive(false);
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level36") == 1)
        {
            levels[35].enabled = true;
            levels[35].transform.Find("lock").gameObject.SetActive(false);
            levels[34].enabled = true;
            levels[34].transform.Find("lock").gameObject.SetActive(false);
            levels[33].enabled = true;
            levels[33].transform.Find("lock").gameObject.SetActive(false);
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level37") == 1)
        {
            levels[36].enabled = true;
            levels[36].transform.Find("lock").gameObject.SetActive(false);
            levels[35].enabled = true;
            levels[35].transform.Find("lock").gameObject.SetActive(false);
            levels[34].enabled = true;
            levels[34].transform.Find("lock").gameObject.SetActive(false);
            levels[33].enabled = true;
            levels[33].transform.Find("lock").gameObject.SetActive(false);
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
        }


        if (PlayerPrefs.GetInt("level38") == 1)
        {
            levels[37].enabled = true;
            levels[37].transform.Find("lock").gameObject.SetActive(false);
            levels[36].enabled = true;
            levels[36].transform.Find("lock").gameObject.SetActive(false);
            levels[35].enabled = true;
            levels[35].transform.Find("lock").gameObject.SetActive(false);
            levels[34].enabled = true;
            levels[34].transform.Find("lock").gameObject.SetActive(false);
            levels[33].enabled = true;
            levels[33].transform.Find("lock").gameObject.SetActive(false);
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level39") == 1)
        {
            levels[38].enabled = true;
            levels[38].transform.Find("lock").gameObject.SetActive(false);
            levels[37].enabled = true;
            levels[37].transform.Find("lock").gameObject.SetActive(false);
            levels[36].enabled = true;
            levels[36].transform.Find("lock").gameObject.SetActive(false);
            levels[35].enabled = true;
            levels[35].transform.Find("lock").gameObject.SetActive(false);
            levels[34].enabled = true;
            levels[34].transform.Find("lock").gameObject.SetActive(false);
            levels[33].enabled = true;
            levels[33].transform.Find("lock").gameObject.SetActive(false);
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level40") == 1)
        {
            levels[39].enabled = true;
            levels[39].transform.Find("lock").gameObject.SetActive(false);
            levels[38].enabled = true;
            levels[38].transform.Find("lock").gameObject.SetActive(false);
            levels[37].enabled = true;
            levels[37].transform.Find("lock").gameObject.SetActive(false);
            levels[36].enabled = true;
            levels[36].transform.Find("lock").gameObject.SetActive(false);
            levels[35].enabled = true;
            levels[35].transform.Find("lock").gameObject.SetActive(false);
            levels[34].enabled = true;
            levels[34].transform.Find("lock").gameObject.SetActive(false);
            levels[33].enabled = true;
            levels[33].transform.Find("lock").gameObject.SetActive(false);
            levels[32].enabled = true;
            levels[32].transform.Find("lock").gameObject.SetActive(false);
        }*/

        //WCSdk.Instance.LogScreen("Level Selection");
    }

    public void btn_back()
    {
        // WCSdk.Instance.ShowSequence(0);
        startDialog();
        StartCoroutine(Backtomenu());
    }


    public void btnSelectLevel(int levelNum)
    {
        startmission.SetActive(true);
        mylevelselect = levelNum;
        Preferences.Instance.Level = levelNum;
    }
    public void playbutton()
    {
        startmission.GetComponent<Animator>().enabled = false;
        startDialog();
        StartCoroutine(LoadLoading());
    }
    IEnumerator LoadLoading()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel("LoadingScene");
    }

    IEnumerator Backtomenu()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel("MainMenu");
    }

    public static void startDialog()
    {
#if UNITY_ANDROID
        Handheld.SetActivityIndicatorStyle(AndroidActivityIndicatorStyle.Large);
        Handheld.StartActivityIndicator();
# endif
    }


}
