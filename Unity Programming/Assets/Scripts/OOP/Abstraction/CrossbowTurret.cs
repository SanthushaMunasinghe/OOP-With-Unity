using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowTurret : Turret
{
    public void CrossbowAim()
    {
        Aim();
    }

    public override void Shoot()
    {
        Debug.Log("Shoot Arrows");
    }
}
