using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinOrLose : MonoBehaviour
{
    public double playercardvalue, aicardvalue;
    public player a;
    public AI b;
    public void Start()
    {
        GameObject.Find("Win").GetComponent<Text>().enabled = false;
        GameObject.Find("Lose").GetComponent<Text>().enabled = false;
    }

    public void winorlose()
    {
        playercardvalue = a.playercardvalue;
        aicardvalue = b.aicardvalue;
        
        if (aicardvalue > 10.5)
        {
            aicardvalue = 0;
        }
        if (playercardvalue > 10.5)
        {
            playercardvalue = 0;
        }

        if((b.clicktime == 5) && (aicardvalue <=10.5))
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = true;
        }
        else if((a.clicktime == 5) && (playercardvalue <=10.5))
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
        }
        else if (aicardvalue - playercardvalue >= 0)
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = true;
        }
        else
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
        }
    }
}
