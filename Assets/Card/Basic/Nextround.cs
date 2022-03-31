using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Nextround : MonoBehaviour
{
    public Deck Deck;
    public player player;
    public AI AI;
    public ShowAIpoint ShowAIpoint;
    public Showplayerpoint Showplayerpoint;
    public WinOrLose WinOrLose;
    public Button RoundEnd;

    public void nextrounddelay()
    {
        Invoke( "nextround" , 1.0f);
    }
    void nextround()
    {
        //Deck.cs
        //建牌組
        for(int cardNumber = 0; cardNumber <= 51; cardNumber++)
        {
            Deck.card[cardNumber] = cardNumber + 1;
        }

        ///洗牌
        for(int cardNumber = 0; cardNumber <= 51; cardNumber++)
        {
            int ranCardNumber = Random.Range(0, 51);//獲得隨機牌組位置
            double temp;//建立交換的暫存區
            temp = Deck.card[cardNumber];
            Deck.card[cardNumber] = Deck.card[ranCardNumber];
            Deck.card[ranCardNumber] = temp;
        }

        //player.cs
        for(int playercardNumber = 0; playercardNumber < 4; playercardNumber++)
        {
            player.playercard[playercardNumber] = 0;
        }
        player.i = 0;
        player.clicktime = 0;
        player.playercardvalue = 0;
        for(int j = 0; j < 5; j++)
        {
            player.forplayercardvalue[j] = player.playercard[j];
        }

        //AI.cs
        for(int aicardNumber = 0; aicardNumber < 4; aicardNumber++)
        {
            AI.aicard[aicardNumber] = 0;
        }
        AI.aicardvalue = 0;
        for(int j = 0; j <= 4; j++)
        {
            AI.foraicardvalue[j] = AI.aicard[j];
        }
        AI.clicktime = 0;

        //ShowAIpoint.cs
        ShowAIpoint.AIcardpointText.text = '0'.ToString();

        //Showplayerpoint.cs
        Showplayerpoint.playercardpointText.text = '0'.ToString();
    
        //winOrLose
        GameObject.Find("Win").GetComponent<Text>().enabled = false;
        GameObject.Find("Lose").GetComponent<Text>().enabled = false;

        //RoundEnd.cs
        RoundEnd.interactable = true;
    }
}