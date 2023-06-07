using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health; // Private field encapsulated within the class

    protected void SetHealth(int value)
    {
        health = value; // Setter method to set the health value
    }

    protected int GetHealth()
    {
        return health; // Getter method to retrieve the health value
    }

    protected void TakeDamage()
    {
        health --; // Method to reduce the health by the given damage amount
    }

    protected void Heal()
    {
        health ++; // Method to increase the health by the given heal amount
    }
}
