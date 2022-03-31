using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIthirdcard : MonoBehaviour
{
    public Text thirdAIcardText;
    public void ShowthirdAIcard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 3)
        {
            thirdAIcardText.text = GameObject.Find("getcard").GetComponent<AI>().aicard[2].ToString();
            break;
        }
    }
}