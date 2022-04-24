using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyDiss : MonoBehaviour
{
    void Start()
    {
        if (bgSystem.isGambling == true)
        {
            gameObject.SetActive(false);
        }
    }
}
