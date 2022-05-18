using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysplayMainBGM : MonoBehaviour
{
    static AlwaysplayMainBGM _instance;
    public static AlwaysplayMainBGM instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AlwaysplayMainBGM>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }
    private void Awake() 
    {
        //此腳本永不銷毀，且每次進入初始場景時進行判斷，若存在重複的則銷毀
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != _instance)
        {
            Destroy(gameObject);
        }
    }
}