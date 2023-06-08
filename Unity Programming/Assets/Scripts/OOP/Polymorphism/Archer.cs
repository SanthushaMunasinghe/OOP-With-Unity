using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Soldire
{
    public void Walk()
    {
        Walk("Archer");
    }

    public void Sprint()
    {
        Sprint("Archer");
    }

    public override void Attack()
    {
        Debug.Log("Shoot Arrows");
    }
}
