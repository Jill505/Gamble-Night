using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instruction : MonoBehaviour
{
    public GameObject instructions;
    public void loadgame()
    {
        Destroy(instructions);
        GameObject.Find("playercardspawner").GetComponent<ImportplayerPoker>().tempplace();
        GameObject.Find("AIcardspawner").GetComponent<ImportAIPoker>().tempplace();
    }
}
