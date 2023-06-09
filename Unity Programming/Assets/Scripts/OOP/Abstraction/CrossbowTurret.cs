using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowTurret : Turret, ITurret
{
    public void CrossbowAim()
    {
        Aim();
    }

    public override void Shoot()
    {
        Debug.Log("Shoot Arrows");
    }

    public void Reload()
    {
        Debug.Log("Crossbow Reload");
    }
}
