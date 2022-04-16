using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Nextround : MonoBehaviour
{    
    public void delaynextround()
    {
        Invoke( "nextround" , 2.0f);
    }
    public void nextround()
    {
        SceneManager.LoadScene(7);
    }
}