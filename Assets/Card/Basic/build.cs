using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class build : MonoBehaviour
{
    static bool enter = true;
    public GameObject instructions;
    public Button hit;
    public Button stand;
    void Start()
    {
        if(enter == true)
        {
            Instantiate(instructions, new Vector3(0, 0, 0), transform.rotation);
            enter = false;
        }
        else
        {
            GameObject.Find("playercardspawner").GetComponent<ImportplayerPoker>().tempplace();
            GameObject.Find("AIcardspawner").GetComponent<ImportAIPoker>().tempplace();
            hit.interactable = true;
            stand.interactable = true;
        }
    }
}
