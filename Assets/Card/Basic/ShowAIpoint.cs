using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAIpoint : MonoBehaviour
{
    public Text AIcardpointText;
    public void ShowAIcardPoint()
    {
        while(GameObject.Find("getcard").GetComponent<AI>().clicktime == 1)
        {
            AIcardpointText.text = GameObject.Find("getcard").GetComponent<AI>().aicardvalue.ToString();
            break;
        }
    }
}