using UnityEngine;
using System.Collections;

public class Preferences: MonoBehaviour 
{ 

    static Preferences _instance;
    private int _level = 1;
    private int _levelUnlock = 1;
    private int _score = 0;
    private int _rateUs = 1;
    private int _SwordSelected = 1;
    private int _Sword1Unlock=0;
    private int _Sword2Unlock=0;

    private int _control = 1;

    public static Preferences Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Preferences();
            return _instance;
        }
    }

    private Preferences()
    {
        Load();
    }
    void Load()
    {
        _level = PlayerPrefs.GetInt("level", 1);
        _levelUnlock = PlayerPrefs.GetInt("levelUnlock", 1);
        _score = PlayerPrefs.GetInt("score", 0);
        _rateUs = PlayerPrefs.GetInt("rateUs", 1);
        _control = PlayerPrefs.GetInt("control", 1);
        _SwordSelected = PlayerPrefs.GetInt("swordSelected", 1);
        _Sword1Unlock = PlayerPrefs.GetInt("sword1Unlock", 0);
        _Sword2Unlock = PlayerPrefs.GetInt("sword2Unlock", 0);
    }

    void Save()
    {
        PlayerPrefs.SetInt("level", _level);
        PlayerPrefs.SetInt("levelUnlock", _levelUnlock);
        PlayerPrefs.SetInt("score", _score);
        PlayerPrefs.SetInt("rateUs", _rateUs);
        PlayerPrefs.SetInt("control", _control);
        PlayerPrefs.SetInt("swordSelected", _SwordSelected);
        PlayerPrefs.SetInt("sword1Unlock", _Sword1Unlock);
        PlayerPrefs.SetInt("sword2Unlock", _Sword2Unlock);

        PlayerPrefs.Save();
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Load();
    }
   

    public int Level
    {
        get{    return _level;    }
        set {   _level = value;    Save();  }
    }


    public int SwordSelected
    {
        get { return _SwordSelected; }
        set { _SwordSelected = value; Save(); }
    }


    public int Sword1Unlock
    {
        get { return _Sword1Unlock; }
        set { _Sword1Unlock = value; Save(); }
    }


    public int Sword2Unlock
    {
        get { return _Sword2Unlock; }
        set { _Sword2Unlock = value; Save(); }
    }


    public int LevelUnlock
    {
        get { return _levelUnlock; }
        set { _levelUnlock = value; Save(); }
    }

    public int Score
    {
        get{    return _score;    }
        set{   _score = value;  Save(); }
    }
    
    public int RateUs
    {
        get{    return _rateUs;    }
        set{    _rateUs = value;    Save(); }
    }
    /// controls setup
    public int Control
    {
        get { return _control; }
        set { _control = value; Save(); }
    }
    

}
