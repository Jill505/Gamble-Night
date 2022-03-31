using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportPoker : MonoBehaviour
{
    public GameObject[] poker = new GameObject[52];
    public int serilize = 1;
    void Start()
    {
        if(this.tag == "playercard1")
        {
            serilize = 1;
        }
        else if(this.tag == "playercard2")
        {
            serilize = 2;
        }
        else if(this.tag == "playercard3")
        {
            serilize = 3;
        }
        else if(this.tag == "playercard4")
        {
            serilize = 4;
        }
        else if(this.tag == "playercard5")
        {
            serilize = 5;
        }
    }
    
    public player player;
    public GameObject[] card = new GameObject[5];
    public GameObject[] playerpoker = new GameObject[5];
    public void showpoker()
    {
        if(player.clicktime == 1)
        {
            card[player.clicktime - 1] = poker[(int)player.playercard[player.clicktime - 1]];
            Instantiate(card[player.clicktime - 1], transform.position, transform.rotation);
        }
        else if (player.clicktime == 2)
        {
            card[player.clicktime - 1] = poker[(int)player.playercard[player.clicktime - 1]];
            Instantiate(card[player.clicktime - 1], transform.position, transform.rotation);
        }
        else if (player.clicktime == 3)
        {
            card[player.clicktime - 1] = poker[(int)player.playercard[player.clicktime - 1]];
            Instantiate(card[player.clicktime - 1], transform.position, transform.rotation);
        }
        else if (player.clicktime == 4)
        {
            card[player.clicktime - 1] = poker[(int)player.playercard[player.clicktime - 1]];
            Instantiate(card[player.clicktime - 1], transform.position, transform.rotation);
        }
        else if (player.clicktime == 5)
        {
            card[player.clicktime - 1] = poker[(int)player.playercard[player.clicktime - 1]];
            Instantiate(card[player.clicktime - 1], transform.position, transform.rotation);
        }
    }
}
