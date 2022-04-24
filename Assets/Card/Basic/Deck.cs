using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public double[] card = new double[52];
    public GameObject instructions;
    public void Start() 
    {
        //建牌組
        for(int cardNumber = 0; cardNumber <= 51; cardNumber++)
        {
            card[cardNumber] = cardNumber + 1;
        }

        ///洗牌
        for(int cardNumber = 0; cardNumber <= 51; cardNumber++)
        {
            int ranCardNumber = Random.Range(0, 51);//獲得隨機牌組位置
            double temp;//建立交換的暫存區
            temp = card[cardNumber];
            card[cardNumber] = card[ranCardNumber];
            card[ranCardNumber] = temp;
        }
    }
}