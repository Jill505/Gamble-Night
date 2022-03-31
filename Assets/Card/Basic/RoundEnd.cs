using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundEnd : MonoBehaviour
{
    public void Update()
    {
        if(GameObject.Find("getcard").GetComponent<player>().clicktime == 5)
        {
            this.GetComponent<Button>().interactable = false;
        }
    }
}
