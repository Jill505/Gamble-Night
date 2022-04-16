using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinSync : MonoBehaviour
{
    
    bool mode;//T=故事 F=普通
    // Start is called before the first frame update
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

    // Update is called once per frame
    GameObject storyTeller;
    void Update()
    {
        if (mode == true)
        {
            gameObject.GetComponent<Text>().text = "籌碼數量：" + storyTeller.GetComponent<storyGam>().storyCoin;
        }
        else
        {
            gameObject.GetComponent<Text>().text = "籌碼數量：" + bgSystem.gold;
        }
    }
}
