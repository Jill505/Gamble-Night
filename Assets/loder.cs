using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bgSystem.gold = PlayerPrefs.GetInt("GambleGold");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
