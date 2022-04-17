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
    }
    public void winorlose()
    {
        playercardvalue = player.playercardvalue;
        aicardvalue = AI.aicardvalue;
        
        if((AI.clicktime == 5) && (aicardvalue <=10.5))
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = true;
            Level.win = Level.win - 1;
            if(bgSystem.isGambling == false)
            {
                bgSystem.gold-=100;
            }
            if(bgSystem.isGambling == true)
            {
                GameObject.Find("GamestoryTeller").GetComponent<storyGam>().storyCoin-=100;
            }
        }
        else if((player.clicktime == 5) && (playercardvalue <=10.5))
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
            Level.win = Level.win + 1;
            if(bgSystem.isGambling == false)
            {
                bgSystem.gold+=100;
            }
            if(bgSystem.isGambling == true)
            {
                GameObject.Find("GamestoryTeller").GetComponent<storyGam>().storyCoin+=100;
            }
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
            Level.win = Level.win - 1;
            if(bgSystem.isGambling == false)
            {
                bgSystem.gold-=100;
            }
            if(bgSystem.isGambling == true)
            {
                GameObject.Find("GamestoryTeller").GetComponent<storyGam>().storyCoin-=100;
            }
        }
        else
        {
            GameObject.Find("Win").GetComponent<Text>().enabled = true;
            Level.win = Level.win + 1;
            if(bgSystem.isGambling == false)
            {
                bgSystem.gold+=100;
            }
            if(bgSystem.isGambling == true)
            {
                GameObject.Find("GamestoryTeller").GetComponent<storyGam>().storyCoin+=100;
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
}
