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
    int a;
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Instantiate(temp, new Vector2(X_axis[i], Y_axis[i]), transform.rotation);
        }
    }

    public void showpoker()
    {
        card[player.clicktime - 1] = poker[(int)player.playercard[player.clicktime - 1] - 1];
        Instantiate(card[player.clicktime - 1], new Vector2(X_axis[a], Y_axis[a]), transform.rotation);
        a++;
    }
}