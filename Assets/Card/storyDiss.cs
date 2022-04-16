using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storyDiss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (bgSystem.isGambling == true)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
