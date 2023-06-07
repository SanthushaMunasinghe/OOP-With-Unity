using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : Player
{
    [SerializeField] private Text healthValue;

    void Start()
    {
        SetHealth(100);
    }

    void Update()
    {
        healthValue.text = "Health: " + GetHealth() + "%";
    }

    public void DamageButton()
    {
        int randDamage = Random.Range(1, 11);

        for (int i = 0; i < randDamage; i++)
        {
            if (GetHealth() > 0)
            {
                TakeDamage();
            }
        }
    }
    
    public void HealButton()
    {
        int randHealth = Random.Range(1, 11);

        for (int i = 0; i < randHealth; i++)
        {
            if (GetHealth() < 100)
            {
                Heal();
            }
        }
    }
}
