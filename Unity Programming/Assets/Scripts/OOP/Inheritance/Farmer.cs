using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : Character
{
    public void MovingEvent()
    {
        Move("Farmer");
    }

    public void StandingEvent()
    {
        Stand("Farmer");
    }

    public void Farming()
    {
        Debug.Log("Farmer is farming");
    }
}
