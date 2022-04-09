using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{
    static public int serilize;
    static public int storycoin = 0;
    static public int normalcoin = 0;
    public void storyMode()
    {
        serilize = 1;
    }

    public void normalMode()
    {
        serilize = 2;
    }
}
