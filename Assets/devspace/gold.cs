using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour
{
    static public int golds;
    // Start is called before the first frame update
    void Start()
    {
        golds = PlayerPrefs.GetInt("golds");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addgold()
    {
        golds = golds + 100;
        PlayerPrefs.SetInt("golds", golds);
    }
    public void minusgold()
    {
        golds = golds - 100;
        PlayerPrefs.SetInt("golds", golds);
    }
}
