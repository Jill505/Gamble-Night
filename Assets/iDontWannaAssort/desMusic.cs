using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desMusic : MonoBehaviour
{
    GameObject musicPlaying;
    // Start is called before the first frame update
    void Awake()
    {
        musicPlaying = GameObject.Find("EventHorizon");
    }

    // Update is called once per frame
    void Start()
    {
        Destroy(musicPlaying);
    }
}
