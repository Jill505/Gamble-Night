using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIforthcard : MonoBehaviour
{
    public Text forthAIcardText;
    public void ShowforthAIcard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 4)
        {
            forthAIcardText.text = GameObject.Find("getcard").GetComponent<AI>().aicard[3].ToString();
            break;
        }
    }
}