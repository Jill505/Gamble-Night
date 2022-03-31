using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Fungus; //請著重注意這行


public class godsys : MonoBehaviour
{
    static public int testGold;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Flowchart.ExecuteBlock(CSspeak);
            //目前為止看起來最成功的
        }
    }
    //Flowchart.ExecuteBlock(string, CSspeak);
    //Message Received(CSspeak);
    //Flowchart.BroadcastFungusMessage(CSspeak);
    public int times = 2;
    public void cooladd()
    {
        godsys.testGold = godsys.testGold * times;
    }

}
