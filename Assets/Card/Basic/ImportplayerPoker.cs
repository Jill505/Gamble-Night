using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportplayerPoker : MonoBehaviour
{
    public GameObject[] poker = new GameObject[52];
    public GameObject[] card = new GameObject[5];
    public GameObject temp;
    public player player;
    public float[] X_axis = new float[5];
    public float[] Y_axis = new float[5];
    public int angle = 50;
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            GameObject go1 =  Instantiate(temp, new Vector2(X_axis[i], Y_axis[i]), transform.rotation);
            go1.transform.eulerAngles = new Vector3(0, 0, angle);
            angle = angle - 25;
        }
        angle = 50;
    }

    public void showpoker()
    {
        card[player.clicktime - 1] = poker[(int)player.playercard[player.clicktime - 1] - 1];
        GameObject go2 = Instantiate(card[player.clicktime - 1], new Vector2(X_axis[player.clicktime - 1], Y_axis[player.clicktime - 1]), transform.rotation);
        go2.transform.eulerAngles = new Vector3(0, 0, angle);
        angle = angle - 25;
    }
}