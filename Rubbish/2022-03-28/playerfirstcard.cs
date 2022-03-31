using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerfirstcard : MonoBehaviour
{
    
    public void start()
    {
        gameObject.GetComponent<SpriteRenderer>( ).sprite = (Sprite)Resources.Load<Sprite>("1");
        
        /*string filename = GameObject.Find("getcard").GetComponent<player>().playercard[0].ToString();
        while(GameObject.Find("getcard").GetComponent<player>().clicktime == 1)
        {
            gameObject.GetComponent<SpriteRenderer>( ).sprite = (Sprite)Resources.Load<Sprite>(filename);
            break;
        }*/
    }
}