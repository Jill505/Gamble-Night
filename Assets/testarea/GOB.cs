using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void goA()
    {
        SceneManager.LoadScene(1);
    }
    public void goB()
    {
    SceneManager.LoadScene(2);
}
}
