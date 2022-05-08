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
        SceneManager.LoadScene(6);
        Destroy(GameObject.Find("The Long Dark Main"));
    }

    public void goshop()
    {
        SceneManager.LoadScene(5);
    }

    public void gocard()
    {
        SceneManager.LoadScene(7);
        Destroy(GameObject.Find("The Long Dark Main"));
    }
}
