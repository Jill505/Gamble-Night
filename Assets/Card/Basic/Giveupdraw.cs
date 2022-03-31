using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Giveupdraw : MonoBehaviour
{
    public Button End;
    public void Giveup()
    {
        End.interactable = false;
    }
}