using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportAIPoker : MonoBehaviour
{
    public GameObject[] poker = new GameObject[52];
    public GameObject[] card = new GameObject[5];
    public GameObject back;
    public GameObject temp;
    public AI AI;
    public float[] X_axis = new float[5];
    public float[] Y_axis = new float[5];
    public int angle = 50;
    public int i = 1;
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            GameObject go1 =  Instantiate(temp, new Vector2(X_axis[i], Y_axis[i]), transform.rotation);
            go1.transform.eulerAngles = new Vector3(0, 0, angle * -1);
            angle = angle - 25;
        }
        angle = 25;
    }
    public void nextrounddelay()//注意 Invoke一定要放在方法中執行
{
        Invoke( "showpoker" , 0.5f);//0.5f為延遲一秒鐘調用
}
    public void showpoker()
    {
        
        if(AI.clicktime - 1 == 0)
        {
            card[0] = poker[(int)AI.aicard[0] - 1];
            GameObject go2 = Instantiate(card[0], new Vector2(X_axis[0], Y_axis[0]), transform.rotation);
            go2.transform.eulerAngles = new Vector3(0, 0, -50);
        }
        else if(AI.aicard[i] != 0)
        {
            card[AI.clicktime - 1] = back;
            GameObject go2 = Instantiate(card[AI.clicktime - 1], new Vector2(X_axis[AI.clicktime - 1], Y_axis[AI.clicktime - 1]), transform.rotation);
            go2.transform.eulerAngles = new Vector3(0, 0, angle * -1);
            angle = angle - 25;
            i++;
        }
    }
}