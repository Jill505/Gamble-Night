using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class port: MonoBehaviour
{
    public Text storycoin, normalcoin;
    void Start()
    {
        if (Mode.serilize == 1)
        {
            storycoin.text = Mode.storycoin.ToString();
            GameObject.Find("storycoin").GetComponent<Text>().enabled = true;
        }
        if (Mode.serilize == 2)
        {
            normalcoin.text = Mode.normalcoin.ToString();
            GameObject.Find("normalcoin").GetComponent<Text>().enabled = true;
        }
    }
}
