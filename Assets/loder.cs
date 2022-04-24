using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loder : MonoBehaviour
{
    void Start()
    {
        bgSystem.gold = PlayerPrefs.GetInt("GambleGold");
    }
}
