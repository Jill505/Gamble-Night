using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIfifthcard : MonoBehaviour
{
    public Text fifthAIcardText;
    public void ShowfifthAIcard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 5)
        {
            fifthAIcardText.text = GameObject.Find("getcard").GetComponent<AI>().aicard[4].ToString();
            break;
        }
    }
}