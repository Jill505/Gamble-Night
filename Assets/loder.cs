using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loder : MonoBehaviour
{
    void Start()
    {
        bgSystem.gold = PlayerPrefs.GetInt("GambleGold");
    }
    public void BTM()
    {
        SceneManager.LoadScene("Main");
    }

    public void goShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
