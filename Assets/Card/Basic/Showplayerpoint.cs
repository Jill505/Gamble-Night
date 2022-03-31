using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showplayerpoint : MonoBehaviour
{
    public Text playercardpointText;
    public void ShowPlayerPoint()
    {
        playercardpointText.text = GameObject.Find("getcard").GetComponent<player>().playercardvalue.ToString();
    }
}
