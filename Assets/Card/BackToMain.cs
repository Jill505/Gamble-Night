﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    public void toMain()
    {
        SceneManager.LoadScene(0);
    }
    /* 故事模式時消失
    void Start()
    {
        if (bgSystem.isGambling == true)
        {
            gameObject.SetActive(false);
        }
    }*/
}
