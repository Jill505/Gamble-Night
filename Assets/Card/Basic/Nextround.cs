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
        Invoke( "nextround" , 4.0f);
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
    public void VeryLose()
    {
        if(GameObject.Find("storyTeller").GetComponent<storyGam>().storyCoin <= 100 || bgSystem.gold <= 100)
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = false;
            GameObject.Find("VeryLose").GetComponent<Text>().enabled = true;
        }
    }
}