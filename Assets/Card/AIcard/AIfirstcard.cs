using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIfirstcard : MonoBehaviour
{
    public Text firstAIcardText;
    public void ShowfirstAIcard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 1)
        {
            firstAIcardText.text = GameObject.Find("getcard").GetComponent<AI>().aicard[0].ToString();
            break;
        }
    }
}