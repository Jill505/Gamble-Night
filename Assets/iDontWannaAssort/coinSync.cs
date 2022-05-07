using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinSync : MonoBehaviour
{
    
    public bool mode;//T=故事 F=普通
    void Start()
    {
        if (bgSystem.isGambling == true)
        {
            mode = true;
        }
        else
        {
            mode = false;
        }
        storyTeller = GameObject.Find("storyTeller");
    }
    GameObject storyTeller;
    void Update()
    {
        /*
        if (bgSystem.isGambling == true)
        {
            mode = true;
        }
        else
        {
            mode = false;
        }*/
        
        if (mode == true)
        {
            gameObject.GetComponent<Text>().text = "籌碼數量：" + storyGam.storyCoin.ToString();
        }
        else
        {
            gameObject.GetComponent<Text>().text = "持有金錢量：" + bgSystem.gold;
        }
    }
}
