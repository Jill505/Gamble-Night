using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerfirstcard : MonoBehaviour
{
    public Text firstplayercardText;
    public void showfirstcard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 1)
        {
            firstplayercardText.text = GameObject.Find("getcard").GetComponent<player>().playercard[0].ToString();
            break;
        }
    }
    
}