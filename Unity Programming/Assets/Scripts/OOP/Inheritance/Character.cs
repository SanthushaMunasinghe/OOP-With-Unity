using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected void Move(string character)
    {
        Debug.Log(character + " is moving");
    }

    protected void Stand(string character)
    {
        Debug.Log(character + " is standing");
    }
}
