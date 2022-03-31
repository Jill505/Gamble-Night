using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerforthcard : MonoBehaviour
{
    public Text forthplayercardText;
    public void Showforthplayercard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 4)
        {
            forthplayercardText.text = GameObject.Find("getcard").GetComponent<player>().playercard[3].ToString();
            break;
        }
    }
}
