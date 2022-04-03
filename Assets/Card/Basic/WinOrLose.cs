using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinOrLose : MonoBehaviour
{
    public double playercardvalue, aicardvalue;
    public GameObject[] poker = new GameObject[52];
    public GameObject[] card = new GameObject[5];
    public float[] X_axis = new float[5];
    public float[] Y_axis = new float[5];
    public player player;
    public AI AI;
    public void Start()
    {
        GameObject.Find("Win").GetComponent<Text>().enabled = false;
        GameObject.Find("Lose").GetComponent<Text>().enabled = false;
    }

    public void winorlose()
    {
        playercardvalue = player.playercardvalue;
        aicardvalue = AI.aicardvalue;
        
        if((AI.clicktime == 5) && (aicardvalue <=10.5))
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = true;
        }
        else if((player.clicktime == 5) && (playercardvalue <=10.5))
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
        }

        if (aicardvalue > 10.5)
        {
            aicardvalue = 0;
        }
        if (playercardvalue > 10.5)
        {
            playercardvalue = 0;
        }

        if (aicardvalue - playercardvalue >= 0)
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = true;
        }
        else
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
        }
    }


    public void showaicard()
    {
        for(int i = 0; i < 5; i++)
        {
            if(AI.aicard[i] != 0)
            {
                card[AI.clicktime - 1] = poker[(int)AI.aicard[i] - 1];
                Instantiate(card[AI.clicktime - 1], new Vector2(X_axis[i], Y_axis[i]), transform.rotation);
            }
        }
    }
}
