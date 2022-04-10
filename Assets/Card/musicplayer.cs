using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicplayer : MonoBehaviour
{
    public GameObject musicplay;
    void Start()
    {
        Instantiate(musicplay, transform.position, transform.rotation);
    }
}
