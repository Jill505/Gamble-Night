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
    public int angle = 50;
    public void Start()
    {
        GameObject.Find("Win").GetComponent<Text>().enabled = false;
        GameObject.Find("Lose").GetComponent<Text>().enabled = false;
        syncer = GameObject.Find("coin");
    }


    //方便複製用 syncer.GetComponent<coinSync>().mode
    public GameObject syncer;
 
    public void winorlose()//輸贏判斷
    {
        playercardvalue = player.playercardvalue;
        aicardvalue = AI.aicardvalue;
        
        if((player.clicktime == 5) && (playercardvalue <=10.5))
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
            Level.win = Level.win + 1;
            if(syncer.GetComponent<coinSync>().mode == false)
            {
                bgSystem.gold+=100;
                saveCoin();
            }
            if(syncer.GetComponent<coinSync>().mode == true)
            {
                storyGam.storyCoin+=100;
            }
        }

        if (aicardvalue > 10.5)
        {
            aicardvalue = aicardvalue - 10.5;
        }
        if (playercardvalue > 10.5)
        {
            playercardvalue = playercardvalue - 10.5;
        }

        if (aicardvalue - playercardvalue >= 0)
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = true;
            Level.win = Level.win - 1;
            if(syncer.GetComponent<coinSync>().mode == false)
            {
                bgSystem.gold-=100;
                saveCoin();
            }
            if(syncer.GetComponent<coinSync>().mode == true)
            {
                storyGam.storyCoin-=100;
            }
        }
        else
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
            Level.win = Level.win + 1;
            if(syncer.GetComponent<coinSync>().mode == false)
            {
                bgSystem.gold+=100;
                saveCoin();
            }
            if(syncer.GetComponent<coinSync>().mode == true)
            {
                storyGam.storyCoin+=100;
            }
        }
    }


    public Text AIcardpointText;
    public void showaicardandpoint()
    {
        for(int i = 0; i < 5; i++)
        {
            if(AI.aicard[i] != 0)
            {
                card[AI.clicktime - 1] = poker[(int)AI.aicard[i] - 1];
                GameObject go = Instantiate(card[AI.clicktime - 1], new Vector3(X_axis[i], Y_axis[i], 1*-1), transform.rotation);
                go.transform.eulerAngles = new Vector3(0, 0, angle * -1);
            }
            angle = angle - 25;
        }

        AIcardpointText.text = GameObject.Find("getcard").GetComponent<AI>().aicardvalue.ToString();
    }


    void saveCoin()
    {
        PlayerPrefs.SetInt("GambleGold", bgSystem.gold);
    }
}
