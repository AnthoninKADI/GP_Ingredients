using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBase : Interactive
{
    public GameObject Lever;
    public override void OnInteraction()
    {
        Lever.SetActive(true);
    }
}
