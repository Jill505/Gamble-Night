using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Button hit;
    public float timecalcal = 0.0f;
    public bool yeecalStart = false;
    public void calcalStart()//計時開始
    {
        timecalcal = 0.0f;
        yeecalStart = true;
        hit.interactable = false;
    }
    void Update()
    {
        if(yeecalStart == true)
        {
            if(timecalcal >= 0.5)
            {
                yeecalStart = false;
                hit.interactable = true;
            }
        }
    }
    void FixedUpdate()
    {
        timecalcal += Time.fixedDeltaTime;
    }

    //建立玩家牌組陣列
    public double[] playercard = new double[5];
    public void Start()
    {
        for(int playercardNumber = 0; playercardNumber < 4; playercardNumber++)
        {
            playercard[playercardNumber] = 0;
        }
    }
    
    public int i = 0;//取得的卡片位置
    public int clicktime = 0;
    //玩家抽牌方法
    public void playergetcard()
    {
        playercard[clicktime] = GameObject.Find("Main_Camera").GetComponent<Deck>().card[i];
        i++;
        clicktime++;
    }


    public double playercardvalue = 0;//建立玩家點數
    public double[] forplayercardvalue = new double[5];//建立player牌組數值陣列
    //計算玩家點數
    public void countplayercardvalue()
    {
        for(int j = 0; j <= 4; j++)
        {
            forplayercardvalue[j] = playercard[j];
        }

        double tempplayercardvalue = 0;
        //計算玩家點數
        for(int value = 0; value <= 4; value++)
        {
            if((forplayercardvalue[value] % 13 == 1) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 1;
            }
            else if((forplayercardvalue[value] % 13 == 2) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 2;
            }
            else if((forplayercardvalue[value] % 13 == 3) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 3;
            }
            else if((forplayercardvalue[value] % 13 == 4) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 4;
            }
            else if((forplayercardvalue[value] % 13 == 5) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 5;
            }
            else if((forplayercardvalue[value] % 13 == 6) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 6;
            }
            else if((forplayercardvalue[value] % 13 == 7) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 7;
            }
            else if((forplayercardvalue[value] % 13 == 8) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 8;
            }
            else if((forplayercardvalue[value] % 13 == 9) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 9;
            }
            else if((forplayercardvalue[value] % 13 == 10) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 10;
            }
            else if((forplayercardvalue[value] % 13 == 11) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 0.5;
            }
            else if((forplayercardvalue[value] % 13 == 12) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 0.5;
            }
            else if((forplayercardvalue[value] % 13 == 0) && (forplayercardvalue[value] != 0))
            {
                forplayercardvalue[value] = 0.5;
            }
        }
        
        for(int j = 0; j <= 4; j++)
        {
            tempplayercardvalue = tempplayercardvalue + forplayercardvalue[j];
        }

        playercardvalue = tempplayercardvalue;
        
    }
}