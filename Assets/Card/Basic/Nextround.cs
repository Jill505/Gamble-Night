using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Nextround : MonoBehaviour
{
    public GameObject DJ;
    public GameObject DJ2;
    private void Awake()
    {   
        DontDestroyOnLoad(DJ);
        if(GameObject.Find("DJ") == true)
        {
            Destroy(DJ2);
        }

    }
    public void delaynextround()
    {
        Invoke( "nextround" , 2.0f);
    }
    public void nextround()
    {
        DontDestroyOnLoad(DJ);
        SceneManager.LoadScene(8);
    }
}