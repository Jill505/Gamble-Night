using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playersecondcard : MonoBehaviour
{
    public Text secondplayercardText;
    public void Showsecondplayercard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 2)
        {
            secondplayercardText.text = GameObject.Find("getcard").GetComponent<player>().playercard[1].ToString();
            break;
        }
    }
}
