using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Nextround : MonoBehaviour
{
    public void nextround()
    {
        Invoke( "nextround" , 1.0f);
        SceneManager.LoadScene(8);
    }
}