using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class storyGam : MonoBehaviour
{
    void Start()
    {
        //bgSystem.isGambling = true;
        if (storyCoin <= 0)
        {
            SceneManager.LoadScene("gameE2");
        }
        if (storyCoin >= 1000)
        {
            SceneManager.LoadScene("gameE1");
        }
    }
    public static int storyCoin = 500;
}
