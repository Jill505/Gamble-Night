using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerthirdcard : MonoBehaviour
{
    public Text thirdplayercardText;
    public void Showthirdplayercard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 3)
        {
            thirdplayercardText.text = GameObject.Find("getcard").GetComponent<player>().playercard[2].ToString();
            break;
        }
    }
}
