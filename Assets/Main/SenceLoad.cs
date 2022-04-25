using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceLoad : MonoBehaviour
{
    public void godev()
    {
        SceneManager.LoadScene(3);
    }

    public GameObject _instance;
    public void gogame()
    {
        SceneManager.LoadScene(6);
        Destroy(_instance);
    }

    public void goshop()
    {
        SceneManager.LoadScene(5);
        Destroy(_instance);
    }

    public void gocard()
    {
        SceneManager.LoadScene(7);
        Destroy(_instance);
    }
}
