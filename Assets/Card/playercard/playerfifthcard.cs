using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerfifthcard : MonoBehaviour
{
    public Text fifthplayercardText;
    public void Showfifthplayercard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 5)
        {
            fifthplayercardText.text = GameObject.Find("getcard").GetComponent<player>().playercard[4].ToString();
            break;
        }
    }
}
