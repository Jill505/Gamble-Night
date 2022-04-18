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
        Invoke( "nextround" , 2.5f);
    }
    public void nextround()
    {
        if(GameObject.Find("VeryLose").GetComponent<Text>().enabled == true)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(7);
        }
    }
    public void VeryLose()//這邊把你踢出賭場
    {
        if(bgSystem.gold <= 0)
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = false;
            GameObject.Find("Win").GetComponent<Text>().enabled = false;
            GameObject.Find("VeryLose").GetComponent<Text>().enabled = true;
        }
    }
}