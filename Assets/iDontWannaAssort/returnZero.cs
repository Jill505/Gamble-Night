using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnZero : MonoBehaviour
{
    int Zero = 0;
    int shouldDiePhi;
    void Awake()
    {
        bgSystem.gold = PlayerPrefs.GetInt("GambleGold");
        shouldDiePhi = PlayerPrefs.GetInt("shouldDiePhi");

    }
    // Start is called before the first frame update
    void Start()
    {
        //bgSystem.gold = PlayerPrefs.GetInt("GambleGold");
        //setZeroo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //int setZeroo;
    public void setZero()
    {
        bgSystem.gold = 0;
        //setZeroo == PlayerPrefs.GetInt("GambleGold");
        PlayerPrefs.SetInt("GambleGold", bgSystem.gold);

        shouldDiePhi = 0;
        PlayerPrefs.SetInt("shouldDiePhi", shouldDiePhi);

        PlayerPrefs.SetInt("paperA", Zero);
        PlayerPrefs.SetInt("paperB", Zero);
        PlayerPrefs.SetInt("paperC", Zero);
        PlayerPrefs.SetInt("rick", Zero);
        PlayerPrefs.SetInt("charr", Zero);
    }
}
