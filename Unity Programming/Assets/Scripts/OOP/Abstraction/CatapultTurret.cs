using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultTurret : Turret
{
    public void CatapultAim()
    {
        Aim();
    }

    public override void Shoot()
    {
        Debug.Log("Shoot Rocks");
    }
}
