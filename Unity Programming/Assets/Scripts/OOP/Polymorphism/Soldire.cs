using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldire : MonoBehaviour
{
    protected void Walk(string sName)
    {
        Debug.Log(sName + " walk");
    }
    
    protected void Sprint(string sName)
    {
        Debug.Log(sName + " sprint");
    }

    public virtual void Attack()
    {
        Debug.Log("Punch");
    }
}
