using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode : MonoBehaviour
{
    //傳入改變數值 普通模式告知
    public void informChangeGamble()
    {
        bgSystem.isGambling = false;
    }
}
