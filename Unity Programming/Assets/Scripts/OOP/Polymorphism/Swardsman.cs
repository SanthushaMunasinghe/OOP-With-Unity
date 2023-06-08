using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swardsman : Soldire
{
    public void Walk()
    {
        Walk("Swardsman");
    }

    public void Sprint()
    {
        Sprint("Swardsman");
    }

    public override void Attack()
    {
        Debug.Log("Sward Attack");
    }
}
