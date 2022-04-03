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
    
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Instantiate(temp, new Vector2(X_axis[i], Y_axis[i]), transform.rotation);
        }
    }
    
    public void showpoker()
    {
        if(AI.clicktime - 1 == 0)
        {
            card[0] = poker[(int)AI.aicard[0] - 1];
            Instantiate(card[0], new Vector2(X_axis[0], Y_axis[0]), transform.rotation);
        }
        else
        {
            card[AI.clicktime - 1] = back;
            Instantiate(card[AI.clicktime - 1], new Vector2(X_axis[AI.clicktime - 1], Y_axis[AI.clicktime - 1]), transform.rotation);
        }
    }
}