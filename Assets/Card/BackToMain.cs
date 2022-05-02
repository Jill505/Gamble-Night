using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMain : MonoBehaviour
{
    public GameObject _instance;
    public void toMain()
    {
        SceneManager.LoadScene("Main");
        Destroy(_instance);
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
