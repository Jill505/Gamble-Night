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

    public void gogame()
    {
        SceneManager.LoadScene(4);
    }

    public void goshop()
    {
        SceneManager.LoadScene(5);
    }

    public void gocard()
    {
        SceneManager.LoadScene(7);
    }
}
