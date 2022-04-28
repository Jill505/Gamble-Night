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
        hit.interactable = false;
        stand.interactable = false;
        Invoke( "nextround" , 2.5f);
    }

    public Button hit;
    public Button stand;
    public GameObject EventHorizon;
    public void nextround()
    {
        if(GameObject.Find("VeryLose").GetComponent<Text>().enabled == true)
        {
            SceneManager.LoadScene(0);
            Destroy(EventHorizon);
        }
        else
        {
            SceneManager.LoadScene(7);
        }
    }
    public void VeryLose()
    {
        if(bgSystem.isGambling == false && bgSystem.gold <= 0)
        {
            GameObject.Find("Lose").GetComponent<Text>().enabled = false;
            GameObject.Find("Win").GetComponent<Text>().enabled = false;
            GameObject.Find("VeryLose").GetComponent<Text>().enabled = true;
        }
    }
}