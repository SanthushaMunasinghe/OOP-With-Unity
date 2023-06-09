using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Turret : MonoBehaviour
{
    protected void Aim()
    {
        Debug.Log("Aiming");
    }

    public abstract void Shoot();
}
