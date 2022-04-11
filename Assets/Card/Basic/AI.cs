using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    public double[] aicard = new double[5];//建立AI牌組陣列
    public void Start()
    {
        for(int aicardNumber = 0; aicardNumber < 4; aicardNumber++)
        {
            aicard[aicardNumber] = 0;
        }
    }
    public double aicardvalue = 0;//建立AI點數
    public double[] foraicardvalue = new double[5];//建立AI牌組數值陣列
    public void countaicardvalue()
    {
        for(int j = 0; j <= 4; j++)
        {
            foraicardvalue[j] = aicard[j];
        }
        double tempaicardvalue = 0;
        //計算AI點數
        for(int value = 0; value <= 4; value++)
        {
            if((foraicardvalue[value] % 13 == 1) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 1;
            }
            else if((foraicardvalue[value] % 13 == 2) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 2;
            }
            else if((foraicardvalue[value] % 13 == 3) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 3;
            }
            else if((foraicardvalue[value] % 13 == 4) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 4;
            }
            else if((foraicardvalue[value] % 13 == 5) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 5;
            }
            else if((foraicardvalue[value] % 13 == 6) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 6;
            }
            else if((foraicardvalue[value] % 13 == 7) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 7;
            }
            else if((foraicardvalue[value] % 13 == 8) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 8;
            }
            else if((foraicardvalue[value] % 13 == 9) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 9;
            }
            else if((foraicardvalue[value] % 13 == 10) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 10;
            }
            else if((foraicardvalue[value] % 13 == 11) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 0.5;
            }
            else if((foraicardvalue[value] % 13 == 12) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 0.5;
            }
            else if((foraicardvalue[value] % 13 == 0) && (foraicardvalue[value] != 0))
            {
                foraicardvalue[value] = 0.5;
            }
        }
        
        for(int j = 0; j <= 4; j++)
        {
            tempaicardvalue = tempaicardvalue + foraicardvalue[j];
        }

        aicardvalue = tempaicardvalue;
        
    }

    public int clicktime = 0;
    public double value;
    public void aigetcard()
    {
        if(Level.win > 5)
        {
            value = 6.5;
        }
        if(Level.win <= 5)
        {
            value = 6;
        }
        if(Level.win < 0)
        {
            value = 5.5;
        }
        if(aicardvalue <= value)
        {
            aicard[clicktime] = GameObject.Find("Main_Camera").GetComponent<Deck>().card[GetComponent<player>().i];
            GetComponent<player>().i++;
            clicktime++;
        }
    }
    public void Endaigetcard()
    {
        while((aicardvalue <= value) && (clicktime < 5))
        {
            aicard[clicktime] = GameObject.Find("Main_Camera").GetComponent<Deck>().card[GetComponent<player>().i];
            GetComponent<player>().i++;
            countaicardvalue();
            clicktime++;
        }
    }
}