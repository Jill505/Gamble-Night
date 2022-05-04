using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerAll : MonoBehaviour
{
    public int itemStats;
    public string itemName;
    public int price;
    // Start is called before the first frame update
    void Awake()
    {
        itemStats = PlayerPrefs.GetInt(itemName);
    }
    void Start()
    {
        if (itemStats == 1)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buyItem()
    {
        if (bgSystem.gold >= price)
        {
            bgSystem.gold -= price;
            PlayerPrefs.SetInt("GambleGold", bgSystem.gold);
            itemStats = 1;
            PlayerPrefs.SetInt(itemName, itemStats);
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
