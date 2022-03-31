using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAIpoint : MonoBehaviour
{
    public Text AIcardpointText;
    public void ShowAIcardPoint()
    {
        AIcardpointText.text = GameObject.Find("getcard").GetComponent<AI>().aicardvalue.ToString();
    }
}
