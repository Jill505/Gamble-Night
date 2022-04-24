using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnZero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bgSystem.gold = PlayerPrefs.GetInt("GambleGold");
        //setZeroo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //int setZeroo;
    void setZero()
    {
        bgSystem.gold = 0;
        //setZeroo == PlayerPrefs.GetInt("GambleGold");
        PlayerPrefs.SetInt("GambleGold", bgSystem.gold);
    }
}
