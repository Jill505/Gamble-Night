using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instruction : MonoBehaviour
{
    Button hit;
    Button stand;
    public GameObject instructions;
    public void loadgame()
    {
        
        Destroy(instructions);
        GameObject.Find("playercardspawner").GetComponent<ImportplayerPoker>().tempplace();
        GameObject.Find("AIcardspawner").GetComponent<ImportAIPoker>().tempplace();

        //超沒邏輯之為什麼一定要這樣用？？？
        hit = GameObject.Find("Playerdraws").GetComponent<Button>();
        stand = GameObject.Find("Count").GetComponent<Button>();
        hit.interactable = true;
        stand.interactable = true;
    }
}