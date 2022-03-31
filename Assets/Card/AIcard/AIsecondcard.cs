using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIsecondcard : MonoBehaviour
{
    public Text secondAIcardText;
    public void ShowsecondAIcard()
    {
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 2)
        {
            secondAIcardText.text = GameObject.Find("getcard").GetComponent<AI>().aicard[1].ToString();
            break;
        }
    }
}