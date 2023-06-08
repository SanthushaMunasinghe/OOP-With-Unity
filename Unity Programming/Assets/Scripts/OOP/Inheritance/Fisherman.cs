using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisherman : Character
{
    public void MovingEvent()
    {
        Move("Fisherman");
    }

    public void StandingEvent()
    {
        Stand("Fisherman");
    }

    public void Fishing()
    {
        Debug.Log("Fisherman is fishing");
    }
}
