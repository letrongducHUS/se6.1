// Code auto-converted by Control Freak 2 on Monday, February 18, 2019!
using UnityEngine;
using System.Collections;

public class bl_MMExampleManager : MonoBehaviour {

    public int MapID = 2;
    public const string MMName = "MMManagerExample";

    public GameObject[] Maps;
    private bool Rotation = true;

    void Awake()
    {
        MapID = PlayerPrefs.GetInt("MMExampleMapID", 0);
        ApplyMap();
    }

    void ApplyMap()
    {
        for (int i = 0; i < Maps.Length; i++)
        {
            Maps[i].SetActive(false);
        }

        Maps[MapID].SetActive(true);
    }

    void Update()
    {
        if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.R))
        {
            ChangeRotation();
        }
    }

    void ChangeRotation()
    {
        Rotation = !Rotation;
        Maps[MapID].GetComponentInChildren<bl_MiniMap>().RotationMap(Rotation);

    }
    public void ChangeMap(int i)
    {
        PlayerPrefs.SetInt("MMExampleMapID",i);
        Application.LoadLevel(Application.loadedLevel);
    }

    public bl_MiniMap GetActiveMiniMap
    {
        get
        {
            bl_MiniMap m = Maps[MapID].GetComponentInChildren<bl_MiniMap>();
            return m;
        }
    }
}