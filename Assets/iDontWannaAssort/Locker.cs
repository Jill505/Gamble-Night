using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    public int shouldDiePhi;
    // Start is called before the first frame update
    void Awake()
    {
        shouldDiePhi = PlayerPrefs.GetInt("shouldDiePhi");
    }
    void Start()
    {
        if (shouldDiePhi == 1)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void buyPhi()
    {
        if (bgSystem.gold >= 500)
        {
            bgSystem.gold -= 500;
            PlayerPrefs.SetInt("GambleGold", bgSystem.gold);
            shouldDiePhi = 1;
            PlayerPrefs.SetInt("shouldDiePhi", shouldDiePhi);
            Die();
        }
        else
        {
            print("窮鬼走開");
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
