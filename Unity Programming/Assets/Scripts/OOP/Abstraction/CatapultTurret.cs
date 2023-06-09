using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultTurret : Turret, ITurret
{
    public void CatapultAim()
    {
        Aim();
    }

    public override void Shoot()
    {
        Debug.Log("Shoot Rocks");
    }

    public void Reload()
    {
        Debug.Log("Catapult Reload");
    }
}
